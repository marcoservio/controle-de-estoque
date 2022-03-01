using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Modelo;
using System.Data;


namespace DAL
{
    public class DALCompra
    {
        #region //Variaveis

        private DALConexao conexao;

        #endregion


        //Construtor
        public DALCompra(DALConexao cx)
        {
            this.conexao = cx;
        }


        public void Incluir(ModeloCompra modelo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "INSERT INTO compra(com_data, com_nfiscal, com_total, com_nparcelas, com_status, for_cod, tpa_cod) VALUES (?data, ?nfiscal, ?total, ?nparcelas, ?status, ?forcod, ?tpacod); SELECT @@IDENTITY";
                cmd.Parameters.Add("data", MySqlDbType.DateTime);
                cmd.Parameters["data"].Value = modelo.ComData;
                cmd.Parameters.Add(new MySqlParameter("nfiscal", modelo.ComNfiscal));
                cmd.Parameters.Add(new MySqlParameter("total", modelo.ComTotal));
                cmd.Parameters.Add(new MySqlParameter("nparcelas", modelo.ComNparcelas));
                cmd.Parameters.Add(new MySqlParameter("status", modelo.ComStatus));
                cmd.Parameters.Add(new MySqlParameter("forcod", modelo.ForCod));
                cmd.Parameters.Add(new MySqlParameter("tpacod", modelo.TpaCod));

                modelo.ComCod = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public void Alterar(ModeloCompra modelo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "UPDATE compra SET com_data = ?data, com_nfiscal = ?nfiscal, com_total = ?total, com_nparcelas = ?nparcelas, com_status = ?status, for_cod = ?forcod, tpa_cod = ?tpacod WHERE com_cod = ?codigo;";
                cmd.Parameters.Add(new MySqlParameter("codigo", modelo.ComCod));
                cmd.Parameters.Add("data", MySqlDbType.DateTime);
                cmd.Parameters["data"].Value = modelo.ComData;
                cmd.Parameters.Add(new MySqlParameter("nfiscal", modelo.ComNfiscal));
                cmd.Parameters.Add(new MySqlParameter("total", modelo.ComTotal));
                cmd.Parameters.Add(new MySqlParameter("nparcelas", modelo.ComNparcelas));
                cmd.Parameters.Add(new MySqlParameter("status", modelo.ComStatus));
                cmd.Parameters.Add(new MySqlParameter("forcod", modelo.ForCod));
                cmd.Parameters.Add(new MySqlParameter("tpacod", modelo.TpaCod));

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public void Excluir(int codigo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "DELETE FROM compra WHERE com_cod = ?codigo;";
                cmd.Parameters.Add(new MySqlParameter("codigo", codigo));

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        //Localiar por codigo do fornecedor
        public DataTable Localizar(int codigo)
        {
            DataTable tabela = new DataTable();

            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT " +
                                                                "c.com_cod, " +
                                                                "f.for_cod, " +
                                                                "f.for_nome, " +
                                                                "c.com_data, " +
                                                                "c.com_nfiscal," +
                                                                "c.com_total, " +
                                                                "c.com_nparcelas, " +
                                                                "c.tpa_cod, " +
                                                                "t.tpa_nome, " +
                                                                "CASE c.com_status " +
                                                                    "WHEN 0 THEN 'Ativo' " +
                                                                    "WHEN 1 THEN 'Inativo' " +
                                                                "END com_status " +
                                                            "FROM " +
                                                                "compra c " +
                                                                    "INNER JOIN " +
                                                                "fornecedor f ON c.for_cod = f.for_cod " +
                                                                    "INNER JOIN " +
                                                                "tipopagamento t ON c.tpa_cod = t.tpa_cod AND f.for_cod = " + codigo.ToString(), conexao.StringConexao);

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
                                                                "c.com_cod, " +
                                                                "f.for_cod, " +
                                                                "f.for_nome, " +
                                                                "c.com_data, " +
                                                                "c.com_nfiscal," +
                                                                "c.com_total, " +
                                                                "c.com_nparcelas, " +
                                                                "c.tpa_cod, " +
                                                                "t.tpa_nome, " +
                                                                "CASE c.com_status " +
                                                                    "WHEN 0 THEN 'Ativo' " +
                                                                    "WHEN 1 THEN 'Inativo' " +
                                                                "END com_status " +
                                                            "FROM " +
                                                                "compra c " +
                                                                    "INNER JOIN " +
                                                                "fornecedor f ON c.for_cod = f.for_cod " +
                                                                    "INNER JOIN " +
                                                                "tipopagamento t ON c.tpa_cod = t.tpa_cod AND f.for_nome LIKE '%" + nome + "%'", conexao.StringConexao);

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
                                                                "c.com_cod, " +
                                                                "f.for_cod, " +
                                                                "f.for_nome, " +
                                                                "c.com_data, " +
                                                                "c.com_nfiscal," +
                                                                "c.com_total, " +
                                                                "c.com_nparcelas, " +
                                                                "c.tpa_cod, " +
                                                                "t.tpa_nome, " +
                                                                "CASE c.com_status " +
                                                                    "WHEN 0 THEN 'Ativo' " +
                                                                    "WHEN 1 THEN 'Inativo' " +
                                                                "END com_status " +
                                                            "FROM " +
                                                                "compra c " +
                                                                    "INNER JOIN " +
                                                                "fornecedor f ON c.for_cod = f.for_cod " +
                                                                    "INNER JOIN " +
                                                                "tipopagamento t ON c.tpa_cod = t.tpa_cod " +
                                                                "ORDER BY c.com_cod;", conexao.StringConexao);

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
                conexao.ObjetoConexao = new MySqlConnection(conexao.StringConexao);
                string mSQL = "SELECT " +
                                   "c.com_cod, " +
                                   "f.for_cod, " +
                                   "f.for_nome, " +
                                   "c.com_data, " +
                                   "c.com_nfiscal," +
                                   "c.com_total, " +
                                   "c.com_nparcelas, " +
                                   "c.tpa_cod, " +
                                   "t.tpa_nome, " +
                                   "CASE c.com_status " +
                                       "WHEN 0 THEN 'Ativo' " +
                                       "WHEN 1 THEN 'Inativo' " +
                                   "END com_status " +
                               "FROM " +
                                   "compra c " +
                                       "INNER JOIN " +
                                   "fornecedor f ON c.for_cod = f.for_cod " +
                                       "INNER JOIN " +
                                   "tipopagamento t ON c.tpa_cod = t.tpa_cod AND c.com_data BETWEEN ?dtinicial AND ?dtfinal";
                MySqlCommand cmd = new MySqlCommand(mSQL, conexao.ObjetoConexao);
                cmd.Parameters.Add("dtinicial", MySqlDbType.DateTime);
                cmd.Parameters["dtinicial"].Value = dtinicial;
                cmd.Parameters.Add("dtfinal", MySqlDbType.DateTime);
                cmd.Parameters["dtfinal"].Value = dtfinal;

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(tabela);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tabela;
        }


        //Localizar por Parcelas em Aberto
        public DataTable LocalizarParcelasEmAberto()
        {
            DataTable tabela = new DataTable();

            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT DISTINCT " +
                                                                "c.com_cod, " +
                                                                "f.for_cod, " +
                                                                "f.for_nome, " +
                                                                "c.com_data, " +
                                                                "c.com_nfiscal, " +
                                                                "c.com_total, " +
                                                                "c.com_nparcelas, " +
                                                                "c.tpa_cod, " +
                                                                "t.tpa_nome, " +
                                                                "CASE c.com_status " +
                                                                    "WHEN 0 THEN 'Ativo' " +
                                                                    "WHEN 1 THEN 'Inativo' " +
                                                                "END com_status " +
                                                            "FROM " +
                                                                "compra c " +
                                                                    "INNER JOIN " +
                                                                "fornecedor f ON c.for_cod = f.for_cod " +
                                                                    "INNER JOIN " +
                                                                "tipopagamento t ON c.tpa_cod = t.tpa_cod " +
                                                                    "INNER JOIN " +
                                                                "parcelascompra p ON p.com_cod = c.com_cod " +
                                                                    "AND p.pco_datapagto IS NULL " +
                                                            "ORDER BY c.com_cod;", conexao.StringConexao);

                da.Fill(tabela);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tabela;
        }


        public int QuantidadeParcelasNãoPagas(int comcod)
        {
            int qtde = 0;

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "SELECT COUNT(com_cod) FROM parcelascompra WHERE com_cod = ?comcod AND pco_datapagto IS NULL;";
                cmd.Parameters.Add(new MySqlParameter("comcod", comcod));

                conexao.Conectar();

                qtde = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return qtde;
        }


        public ModeloCompra CarregaModeloCompra(int codigo)
        {
            ModeloCompra modelo = new ModeloCompra();

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "SELECT * FROM compra WHERE com_cod = ?codigo";
                cmd.Parameters.Add(new MySqlParameter("codigo", codigo));

                conexao.Conectar();

                MySqlDataReader registro = cmd.ExecuteReader();

                if (registro.HasRows)
                {
                    registro.Read();

                    modelo.ComCod = Convert.ToInt32(registro["com_cod"]);
                    modelo.ComData = Convert.ToDateTime(registro["com_data"]);
                    modelo.ComNfiscal = Convert.ToInt32(registro["com_nfiscal"]);
                    modelo.ComTotal = Convert.ToDouble(registro["com_total"]);
                    modelo.ComNparcelas = Convert.ToInt32(registro["com_nparcelas"]);
                    modelo.ComStatus = Convert.ToInt32(registro["com_status"]);
                    modelo.ForCod = Convert.ToInt32(registro["for_cod"]);
                    modelo.TpaCod = Convert.ToInt32(registro["tpa_cod"]);
                }

                registro.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return modelo;
        }
    }
}
