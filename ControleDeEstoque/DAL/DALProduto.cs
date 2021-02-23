using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using MySql.Data.MySqlClient;
using System.Data;


namespace DAL
{
    public class DALProduto
    {
        #region //Variaveis

        private DALConexao conexao;

        #endregion


        public DALProduto(DALConexao cx)
        {
            this.conexao = cx;
        }


        public void Incluir(ModeloProduto modelo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "INSERT INTO produto (pro_nome, pro_descricao, pro_valorpago, pro_valorvenda, pro_qtde, umed_cod, cat_cod, scat_cod) VALUES (?nome, ?descricao, ?valorpago, ?valorvenda, ?pro_qtde, ?umedcod, ?catcod, ?scatcod); SELECT @@IDENTITY";
                cmd.Parameters.Add(new MySqlParameter("nome", modelo.Pro_Nome));
                cmd.Parameters.Add(new MySqlParameter("descricao", modelo.Pro_Descricao));
                cmd.Parameters.Add(new MySqlParameter("valorpago", modelo.Pro_ValorPago));
                cmd.Parameters.Add(new MySqlParameter("valorvenda", modelo.Pro_ValorVenda));
                cmd.Parameters.Add(new MySqlParameter("pro_qtde", modelo.Pro_Qtde));
                cmd.Parameters.Add(new MySqlParameter("umedcod", modelo.Umed_Cod));
                cmd.Parameters.Add(new MySqlParameter("catcod", modelo.Cat_Cod));
                cmd.Parameters.Add(new MySqlParameter("scatcod", modelo.Scat_Cod));

                conexao.Conectar();

                modelo.Cat_Cod = Convert.ToInt32(cmd.ExecuteScalar());
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


        public void Alterar(ModeloProduto modelo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "UPDATE produto SET pro_nome = ?nome, pro_descricao = ?descricao, pro_valorpago = ?valorpago, pro_valorvenda = ?valorvenda, pro_qtde = ?proqtde, umed_cod = ?umedcod, cat_cod = ?catcod, scat_cod = ?scatcod WHERE pro_cod = ?codigo;";
                cmd.Parameters.Add(new MySqlParameter("codigo", modelo.Pro_Cod));
                cmd.Parameters.Add(new MySqlParameter("nome", modelo.Pro_Nome));
                cmd.Parameters.Add(new MySqlParameter("descricao", modelo.Pro_Descricao));
                cmd.Parameters.Add(new MySqlParameter("valorpago", modelo.Pro_ValorPago));
                cmd.Parameters.Add(new MySqlParameter("valorvenda", modelo.Pro_ValorVenda));
                cmd.Parameters.Add(new MySqlParameter("proqtde", modelo.Pro_Qtde));
                cmd.Parameters.Add(new MySqlParameter("umedcod", modelo.Umed_Cod));
                cmd.Parameters.Add(new MySqlParameter("catcod", modelo.Cat_Cod));
                cmd.Parameters.Add(new MySqlParameter("scatcod", modelo.Scat_Cod));

                conexao.Conectar();

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


        public void Alterar(ModeloProduto modelo, bool transacao)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "UPDATE produto SET pro_nome = ?nome, pro_descricao = ?descricao, pro_valorpago = ?valorpago, pro_valorvenda = ?valorvenda, pro_qtde = ?proqtde, umed_cod = ?umedcod, cat_cod = ?catcod, scat_cod = ?scatcod WHERE pro_cod = ?codigo;";
                cmd.Parameters.Add(new MySqlParameter("codigo", modelo.Pro_Cod));
                cmd.Parameters.Add(new MySqlParameter("nome", modelo.Pro_Nome));
                cmd.Parameters.Add(new MySqlParameter("descricao", modelo.Pro_Descricao));
                cmd.Parameters.Add(new MySqlParameter("valorpago", modelo.Pro_ValorPago));
                cmd.Parameters.Add(new MySqlParameter("valorvenda", modelo.Pro_ValorVenda));
                cmd.Parameters.Add(new MySqlParameter("proqtde", modelo.Pro_Qtde));
                cmd.Parameters.Add(new MySqlParameter("umedcod", modelo.Umed_Cod));
                cmd.Parameters.Add(new MySqlParameter("catcod", modelo.Cat_Cod));
                cmd.Parameters.Add(new MySqlParameter("scatcod", modelo.Scat_Cod));

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


        public void Excluir(int codigo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "DELETE FROM produto WHERE pro_cod = ?codigo;";
                cmd.Parameters.Add(new MySqlParameter("codigo", codigo));

                conexao.Conectar();

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


        public DataTable Localizar(string valor)
        {
            DataTable tabela = new DataTable();

            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT p.pro_cod, p.pro_nome, p.pro_descricao, p.pro_qtde, p.pro_valorpago, p.pro_valorvenda, " +
                                                           "p.umed_cod, u.umed_nome, p.cat_cod, c.cat_nome, p.scat_cod, sc.scat_nome " +
                                                           "FROM produto p " +
                                                           "INNER JOIN undmedida u " +
                                                           "ON p.umed_cod = u.umed_cod " +
                                                           "INNER JOIN categoria c " +
                                                           "ON p.cat_cod = c.cat_cod " +
                                                           "INNER JOIN subcategoria sc " +
                                                           "ON p.scat_cod = sc.scat_cod WHERE pro_nome LIKE '%" + valor + "%'", conexao.StringConexao);

                da.Fill(tabela);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tabela;
        }


        public ModeloProduto CarregaModeloProduto(int codigo)
        {
            ModeloProduto modelo = new ModeloProduto();

            try
            {
                conexao.ObjetoConexao = new MySqlConnection(conexao.StringConexao);
                string mSQL = "SELECT * FROM produto WHERE pro_cod = ?codigo";
                MySqlCommand cmd = new MySqlCommand(mSQL, conexao.ObjetoConexao);
                cmd.Parameters.Add(new MySqlParameter("codigo", codigo));

                conexao.Conectar();

                MySqlDataReader registro = cmd.ExecuteReader();

                if (registro.HasRows)
                {
                    registro.Read();

                    modelo.Pro_Cod = Convert.ToInt32(registro["pro_cod"]);
                    modelo.Pro_Nome = Convert.ToString(registro["pro_nome"]);
                    modelo.Pro_Descricao = Convert.ToString(registro["pro_descricao"]);
                    modelo.Pro_ValorPago = Convert.ToDouble(registro["pro_valorpago"]);
                    modelo.Pro_ValorVenda = Convert.ToDouble(registro["pro_valorvenda"]);
                    modelo.Pro_Qtde = Convert.ToInt32(registro["pro_qtde"].ToString());
                    modelo.Umed_Cod = Convert.ToInt32(registro["umed_cod"]);
                    modelo.Cat_Cod = Convert.ToInt32(registro["cat_cod"]);
                    modelo.Scat_Cod = Convert.ToInt32(registro["scat_cod"]);
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


        public ModeloProduto CarregaModeloProduto(int codigo, bool transacao)
        {
            ModeloProduto modelo = new ModeloProduto();

            try
            {
                conexao.ObjetoConexao = new MySqlConnection(conexao.StringConexao);
                string mSQL = "SELECT * FROM produto WHERE pro_cod = ?codigo";
                MySqlCommand cmd = new MySqlCommand(mSQL, conexao.ObjetoConexao);
                cmd.Parameters.Add(new MySqlParameter("codigo", codigo));

                MySqlDataReader registro = cmd.ExecuteReader();

                if (registro.HasRows)
                {
                    registro.Read();

                    modelo.Pro_Cod = Convert.ToInt32(registro["pro_cod"]);
                    modelo.Pro_Nome = Convert.ToString(registro["pro_nome"]);
                    modelo.Pro_Descricao = Convert.ToString(registro["pro_descricao"]);
                    modelo.Pro_ValorPago = Convert.ToDouble(registro["pro_valorpago"]);
                    modelo.Pro_ValorVenda = Convert.ToDouble(registro["pro_valorvenda"]);
                    modelo.Pro_Qtde = Convert.ToInt32(registro["pro_qtde"].ToString());
                    modelo.Umed_Cod = Convert.ToInt32(registro["umed_cod"]);
                    modelo.Cat_Cod = Convert.ToInt32(registro["cat_cod"]);
                    modelo.Scat_Cod = Convert.ToInt32(registro["scat_cod"]);
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
