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
    public class DALItensVenda
    {
        #region //Variaveis

        private DALConexao conexao;

        #endregion


        //Construtor
        public DALItensVenda(DALConexao cx)
        {
            this.conexao = cx;
        }


        public void Incluir(ModeloItensVenda modelo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "INSERT INTO itensvenda(itv_cod, itv_qtde, itv_valor, ven_cod, pro_cod) VALUES (?cod,  ?qtde, ?valor, ?vencod, ?procod);";
                cmd.Parameters.Add(new MySqlParameter("cod", modelo.ItvCod));
                cmd.Parameters.Add(new MySqlParameter("qtde", modelo.ItvQtde));
                cmd.Parameters.Add(new MySqlParameter("valor", modelo.ItvValor));
                cmd.Parameters.Add(new MySqlParameter("vencod", modelo.VenCod));
                cmd.Parameters.Add(new MySqlParameter("procod", modelo.ProCod));

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


        public void Alterar(ModeloItensVenda modelo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "UPDATE itensvenda SET itv_qtde = ?qtde, itv_valor = ?valor WHERE itv_cod = ?cod AND ven_cod = ?vencod AND pro_cod = ?procod;";
                cmd.Parameters.Add(new MySqlParameter("cod", modelo.ItvCod));
                cmd.Parameters.Add(new MySqlParameter("qtde", modelo.ItvQtde));
                cmd.Parameters.Add(new MySqlParameter("valor", modelo.ItvValor));
                cmd.Parameters.Add(new MySqlParameter("vencod", modelo.VenCod));
                cmd.Parameters.Add(new MySqlParameter("procod", modelo.ProCod));

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


        public void Excluir(ModeloItensVenda modelo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "DELETE FROM itensvenda WHERE itv_cod = ?cod AND ven_cod = ?vencod AND pro_cod = ?procod";
                cmd.Parameters.Add(new MySqlParameter("cod", modelo.ItvCod));
                cmd.Parameters.Add(new MySqlParameter("vencod", modelo.VenCod));
                cmd.Parameters.Add(new MySqlParameter("procod", modelo.ProCod));

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


        public void ExcluirTodosItens(int vencod)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "DELETE FROM itensvenda WHERE ven_cod = ?vencod";
                cmd.Parameters.Add(new MySqlParameter("vencod", vencod));

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


        public DataTable Localizar(int vencod)
        {
            DataTable tabela = new DataTable();

            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT i.*, p.pro_nome FROM itensvenda i INNER JOIN produto p ON i.pro_cod = p.pro_cod AND ven_cod = " + vencod.ToString(), conexao.StringConexao);

                da.Fill(tabela);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tabela;
        }


        public ModeloItensVenda CarregaModeloItensVenda(int itvcod, int vencod, int procod)
        {
            ModeloItensVenda modelo = new ModeloItensVenda();

            try
            {
                conexao.ObjetoConexao = new MySqlConnection(conexao.StringConexao);
                string mSQL = "SELECT * FROM itensvenda WHERE itv_cod = ?cod AND ven_cod = ?vencod AND pro_cod = ?procod";
                MySqlCommand cmd = new MySqlCommand(mSQL, conexao.ObjetoConexao);
                cmd.Parameters.Add(new MySqlParameter("cod", itvcod));
                cmd.Parameters.Add(new MySqlParameter("vencod", vencod));
                cmd.Parameters.Add(new MySqlParameter("procod", procod));

                conexao.Conectar();

                MySqlDataReader registro = cmd.ExecuteReader();

                if (registro.HasRows)
                {
                    registro.Read();

                    modelo.ItvCod = itvcod;
                    modelo.ItvValor = Convert.ToDouble(registro["itv_valor"]);
                    modelo.ItvQtde = Convert.ToInt32(registro["itv_qtde"]);
                    modelo.VenCod = vencod;
                    modelo.ProCod = procod;
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
