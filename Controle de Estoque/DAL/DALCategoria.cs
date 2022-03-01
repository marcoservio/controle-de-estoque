using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Modelo;
using System.Data;
using MySql.Data.MySqlClient;


namespace DAL
{
    public class DALCategoria
    {
        #region //Variaveis

        private DALConexao conexao;

        #endregion


        //Construtor
        public DALCategoria(DALConexao cx)
        {
            this.conexao = cx;
        }


        public void Incluir(ModeloCategoria modelo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "INSERT INTO categoria(cat_nome) VALUES (?nome); SELECT @@IDENTITY";
                cmd.Parameters.Add(new MySqlParameter("nome", modelo.CatNome));

                conexao.Conectar();

                modelo.CatCod = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public void Alterar(ModeloCategoria modelo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "UPDATE categoria SET cat_nome = ?nome WHERE cat_cod = ?codigo;";
                cmd.Parameters.Add(new MySqlParameter("codigo", modelo.CatCod));
                cmd.Parameters.Add(new MySqlParameter("nome", modelo.CatNome));

                conexao.Conectar();

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
                cmd.CommandText = "DELETE FROM categoria WHERE cat_cod = ?codigo;";
                cmd.Parameters.Add(new MySqlParameter("codigo", codigo));

                conexao.Conectar();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public DataTable Localizar(string valor)
        {
            DataTable tabela = new DataTable();

            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM categoria WHERE cat_nome LIKE '%" + valor + "%'", conexao.StringConexao);

                da.Fill(tabela);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tabela;
        }


        public ModeloCategoria CarregaModeloCategoria(int codigo)
        {
            ModeloCategoria modelo = new ModeloCategoria();

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "SELECT * FROM categoria WHERE cat_cod = ?codigo";
                cmd.Parameters.Add(new MySqlParameter("codigo", codigo));

                conexao.Conectar();

                MySqlDataReader registro = cmd.ExecuteReader();

                if (registro.HasRows)
                {
                    registro.Read();

                    modelo.CatCod = Convert.ToInt32(registro["cat_cod"]);
                    modelo.CatNome = Convert.ToString(registro["cat_nome"]);
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
