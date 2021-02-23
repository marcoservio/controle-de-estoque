using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data;
using MySql.Data.MySqlClient;


namespace DAL
{
    public class DALVenda
    {
        #region //Variaveis

        private DALConexao conexao;

        #endregion


        //Construtor
        public DALVenda(DALConexao cx)
        {
            this.conexao = cx;
        }


        public void Incluir(ModeloVenda modelo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "INSERT INTO venda(ven_data, ven_nfiscal, ven_total, ven_nparcelas, ven_status, cli_cod, tpa_cod, ven_avista) VALUES (?data, ?nfiscal, ?total, ?nparcelas, ?status, ?clicod, ?tpacod, ?avista); select @@IDENTITY";
                cmd.Parameters.Add("data", MySqlDbType.DateTime);
                cmd.Parameters["data"].Value = modelo.VenData;
                cmd.Parameters.Add(new MySqlParameter("nfiscal", modelo.VenNfiscal));
                cmd.Parameters.Add(new MySqlParameter("total", modelo.VenTotal));
                cmd.Parameters.Add(new MySqlParameter("nparcelas", modelo.VenNparcelas));
                cmd.Parameters.Add(new MySqlParameter("status", modelo.VenStatus));
                cmd.Parameters.Add(new MySqlParameter("clicod", modelo.CliCod));
                cmd.Parameters.Add(new MySqlParameter("tpacod", modelo.TpaCod));
                cmd.Parameters.Add(new MySqlParameter("avista", modelo.VenAvista));

                modelo.VenCod = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }


        public void Alterar(ModeloVenda modelo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "UPDATE venda SET ven_data = ?data, ven_nfiscal = ?nfiscal, ven_total = ?total, ven_nparcelas = ?nparcelas, ven_status = ?status, cli_cod = ?clicod, tpa_cod = ?tpacod, ven_avista = ?avista WHERE ven_cod = ?codigo;";
                cmd.Parameters.Add(new MySqlParameter("codigo", modelo.VenCod));
                cmd.Parameters.Add("data", MySqlDbType.DateTime);
                cmd.Parameters["data"].Value = modelo.VenData;
                cmd.Parameters.Add(new MySqlParameter("nfiscal", modelo.VenNfiscal));
                cmd.Parameters.Add(new MySqlParameter("total", modelo.VenTotal));
                cmd.Parameters.Add(new MySqlParameter("nparcelas", modelo.VenNparcelas));
                cmd.Parameters.Add(new MySqlParameter("status", modelo.VenStatus));
                cmd.Parameters.Add(new MySqlParameter("clicod", modelo.CliCod));
                cmd.Parameters.Add(new MySqlParameter("tpacod", modelo.TpaCod));
                cmd.Parameters.Add(new MySqlParameter("avista", modelo.VenAvista));

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }


        public bool CancelarVenda(int codigo)
        {
            bool retorno = true;

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conexao.ObjetoConexao;
            conexao.Conectar();
            conexao.IniciarTransacao();

            try
            {
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "UPDATE venda SET ven_status = 0 WHERE ven_cod = ?codigo;";
                cmd.Parameters.Add(new MySqlParameter("codigo", codigo));

                cmd.ExecuteNonQuery();

                DataTable tabela = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT pro_cod, itv_qtde FROM itensvenda produto where ven_cod = " + codigo.ToString(), conexao.StringConexao);
                da.Fill(tabela);

                ModeloProduto produto;
                DALProduto dalProduto = new DALProduto(conexao);

                for (int i = 0; i < tabela.Rows.Count; i++)
                {
                    produto = dalProduto.CarregaModeloProduto(Convert.ToInt32(tabela.Rows[i]["pro_cod"]));

                    produto.Pro_Qtde = produto.Pro_Qtde + Convert.ToInt32(tabela.Rows[i]["itv_qtde"]);

                    dalProduto.Alterar(produto, true);
                }

                conexao.TerminarTransacao();
                conexao.Desconectar();
            }
            catch (Exception ex)
            {
                retorno = false;
                conexao.CancelarTransacao();
                conexao.Desconectar();
                throw new Exception(ex.Message);
            }
            finally
            {
                conexao.Desconectar();
            }

            return retorno;
        }


        public void Excluir(int codigo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "DELETE FROM venda WHERE ven_cod = ?codigo;";
                cmd.Parameters.Add(new MySqlParameter("codigo", codigo));

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }


        //Localiar por codigo do fornecedor
        public DataTable Localizar(int codigo)
        {
            DataTable tabela = new DataTable();

            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT " +
                                                                "v.ven_cod, " +
                                                                "c.cli_cod, " +
                                                                "c.cli_nome, " +
                                                                "v.ven_data, " +
                                                                "v.ven_nfiscal," +
                                                                "v.ven_total, " +
                                                                "v.ven_avista, " +
                                                                "v.ven_nparcelas, " +
                                                                "v.tpa_cod, " +
                                                                "t.tpa_nome, " +
                                                                "CASE v.ven_status " +
                                                                    "WHEN 0 THEN 'Ativo' " +
                                                                    "WHEN 1 THEN 'Inativo' " +
                                                                "END ven_status " +
                                                            "FROM " +
                                                                "venda v " +
                                                                    "INNER JOIN " +
                                                                "cliente c ON v.cli_cod = c.cli_cod " +
                                                                    "INNER JOIN " +
                                                                "tipopagamento t ON v.tpa_cod = t.tpa_cod AND c.cli_cod = " + codigo.ToString(), conexao.StringConexao);

                da.Fill(tabela);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tabela;
        }


        //Localiar por nome do fornecedor
        public DataTable Localizar(string nome)
        {
            DataTable tabela = new DataTable();

            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT " +
                                                                "v.ven_cod, " +
                                                                "c.cli_cod, " +
                                                                "c.cli_nome, " +
                                                                "v.ven_data, " +
                                                                "v.ven_nfiscal," +
                                                                "v.ven_total, " +
                                                                "v.ven_avista, " +
                                                                "v.ven_nparcelas, " +
                                                                "v.tpa_cod, " +
                                                                "t.tpa_nome, " +
                                                                "CASE v.ven_status " +
                                                                    "WHEN 0 THEN 'Ativo' " +
                                                                    "WHEN 1 THEN 'Inativo' " +
                                                                "END ven_status " +
                                                            "FROM " +
                                                                "venda v " +
                                                                    "INNER JOIN " +
                                                                "cliente c ON v.cli_cod = c.cli_cod " +
                                                                    "INNER JOIN " +
                                                                "tipopagamento t ON v.tpa_cod = t.tpa_cod AND c.cli_nome LIKE '%" + nome + "%'", conexao.StringConexao);

                da.Fill(tabela);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tabela;
        }


        //Localizar todas as compras
        public DataTable Localizar()
        {
            DataTable tabela = new DataTable();

            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT " +
                                                                "v.ven_cod, " +
                                                                "c.cli_cod, " +
                                                                "c.cli_nome, " +
                                                                "v.ven_data, " +
                                                                "v.ven_nfiscal," +
                                                                "v.ven_total, " +
                                                                "v.ven_avista, " +
                                                                "v.ven_nparcelas, " +
                                                                "v.tpa_cod, " +
                                                                "t.tpa_nome, " +
                                                                "CASE v.ven_status " +
                                                                    "WHEN 0 THEN 'Ativo' " +
                                                                    "WHEN 1 THEN 'Inativo' " +
                                                                "END ven_status " +
                                                            "FROM " +
                                                                "venda v " +
                                                                    "INNER JOIN " +
                                                                "cliente c ON v.cli_cod = c.cli_cod " +
                                                                    "INNER JOIN " +
                                                                "tipopagamento t ON v.tpa_cod = t.tpa_cod", conexao.StringConexao);

                da.Fill(tabela);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tabela;
        }


        //Localizar pro data
        public DataTable Localizar(DateTime dtinicial, DateTime dtfinal)
        {
            DataTable tabela = new DataTable();

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "SELECT " +
                                        "v.ven_cod, " +
                                        "c.cli_cod, " +
                                        "c.cli_nome, " +
                                        "v.ven_data, " +
                                        "v.ven_nfiscal," +
                                        "v.ven_total, " +
                                        "v.ven_avista, " +
                                        "v.ven_nparcelas, " +
                                        "v.tpa_cod, " +
                                        "t.tpa_nome, " +
                                        "CASE v.ven_status " +
                                            "WHEN 0 THEN 'Ativo' " +
                                            "WHEN 1 THEN 'Inativo' " +
                                        "END ven_status " +
                                    "FROM " +
                                        "venda v " +
                                            "INNER JOIN " +
                                        "cliente c ON v.cli_cod = c.cli_cod " +
                                            "INNER JOIN " +
                                        "tipopagamento t ON v.tpa_cod = t.tpa_cod AND v.ven_data BETWEEN ?dtinicial AND ?dtfinal";
                cmd.Parameters.Add("dtinicial", MySqlDbType.DateTime);
                cmd.Parameters["dtinicial"].Value = dtinicial;
                cmd.Parameters.Add("dtfinal", MySqlDbType.DateTime);
                cmd.Parameters["dtfinal"].Value = dtfinal;

                conexao.Conectar();

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(tabela);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conexao.Desconectar();
            }

            return tabela;
        }


        //Localizar por Parcelas em Aberto
        public DataTable LocalizarParcelasEmAberto()
        {
            DataTable tabela = new DataTable();

            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT DISTINCT" +
                                                                    "v.ven_cod, " +
                                                                    "c.cli_cod, " +
                                                                    "c.cli_nome, " +
                                                                    "v.ven_data, " +
                                                                    "v.ven_nfiscal," +
                                                                    "v.ven_total, " +
                                                                    "v.ven_avista, " +
                                                                    "v.ven_nparcelas, " +
                                                                    "v.tpa_cod, " +
                                                                    "t.tpa_nome, " +
                                                                    "CASE v.ven_status " +
                                                                        "WHEN 0 THEN 'Ativo' " +
                                                                        "WHEN 1 THEN 'Inativo' " +
                                                                    "END ven_status " +
                                                                "FROM " +
                                                                    "venda v " +
                                                                        "INNER JOIN " +
                                                                    "cliente c ON v.cli_cod = c.cli_cod " +
                                                                        "INNER JOIN " +
                                                                    "tipopagamento t ON v.tpa_cod = t.tpa_cod" +
                                                                        "INNER JOIN " +
                                                                    "parcelasvenda p ON p.ven_cod = v.ven_cod " +
                                                                        "AND p.pve_datapagto IS NULL " +
                                                                "ORDER BY v.ven_cod;", conexao.StringConexao);

                da.Fill(tabela);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tabela;
        }


        public int QuantidadeParcelasNãoPagas(int codigo)
        {
            int qtde = 0;

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "SELECT COUNT(ven_cod) FROM parcelasvenda WHERE ven_cod = ?vencod AND pve_datapagto IS NULL;";
                cmd.Parameters.Add(new MySqlParameter("comcod", codigo));

                conexao.Conectar();

                qtde = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conexao.Desconectar();
            }

            return qtde;
        }


        public ModeloVenda CarregaModeloVenda(int codigo)
        {
            ModeloVenda modelo = new ModeloVenda();

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "SELECT * FROM venda WHERE ven_cod = ?codigo";
                cmd.Parameters.Add(new MySqlParameter("codigo", codigo));

                conexao.Conectar();

                MySqlDataReader registro = cmd.ExecuteReader();

                if (registro.HasRows)
                {
                    registro.Read();

                    modelo.VenCod = Convert.ToInt32(registro["ven_cod"]);
                    modelo.VenData = Convert.ToDateTime(registro["ven_data"]);
                    modelo.VenNfiscal = Convert.ToInt32(registro["ven_nfiscal"]);
                    modelo.VenTotal = Convert.ToDouble(registro["ven_total"]);
                    modelo.VenNparcelas = Convert.ToInt32(registro["ven_nparcelas"]);
                    modelo.VenStatus = Convert.ToInt32(registro["ven_status"]);
                    modelo.CliCod = Convert.ToInt32(registro["cli_cod"]);
                    modelo.TpaCod = Convert.ToInt32(registro["tpa_cod"]);
                    modelo.VenAvista = Convert.ToInt32(registro["ven_avista"]);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                conexao.Desconectar();
            }

            return modelo;
        }
    }
}
