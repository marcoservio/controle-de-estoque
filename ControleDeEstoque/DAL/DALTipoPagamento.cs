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
    public class DALTipoPagamento
    {
        #region //Variaveis

        private DALConexao conexao;

        #endregion


        //Construtor
        public DALTipoPagamento(DALConexao cx)
        {
            this.conexao = cx;
        }


        public void Incluir(ModeloTipoPagamento modelo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "INSERT INTO tipopagamento(tpa_nome)  VALUES (?nome); SELECT @@IDENTITY";
                cmd.Parameters.Add(new MySqlParameter("nome", modelo.TpaNome));

                conexao.Conectar();

                modelo.TpaCod = Convert.ToInt32(cmd.ExecuteScalar());
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


        public void Alterar(ModeloTipoPagamento modelo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "UPDATE tipopagamento SET tpa_nome = ?nome WHERE tpa_cod = ?codigo;";
                cmd.Parameters.Add(new MySqlParameter("codigo", modelo.TpaCod));
                cmd.Parameters.Add(new MySqlParameter("nome", modelo.TpaNome));

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


        public void Excluir(int codigo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "DELETE FROM tipopagamento WHERE tpa_cod = ?codigo;";
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
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM tipopagamento WHERE tpa_nome LIKE '%" + valor + "%'", conexao.StringConexao);

                da.Fill(tabela);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tabela;
        }


        public ModeloTipoPagamento CarregaModeloTipoPagamento(int codigo)
        {
            ModeloTipoPagamento modelo = new ModeloTipoPagamento();

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "SELECT * FROM tipopagamento WHERE tpa_cod = ?codigo";
                cmd.Parameters.Add(new MySqlParameter("codigo", codigo));

                conexao.Conectar();

                MySqlDataReader registro = cmd.ExecuteReader();

                if (registro.HasRows)
                {
                    registro.Read();

                    modelo.TpaCod = Convert.ToInt32(registro["tpa_cod"]);
                    modelo.TpaNome = Convert.ToString(registro["tpa_nome"]);
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
