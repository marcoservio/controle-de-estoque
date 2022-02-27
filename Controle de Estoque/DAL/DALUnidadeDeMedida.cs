using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using Modelo;


namespace DAL
{
    public class DALUnidadeDeMedida
    {
        #region //Variaveis

        private DALConexao conexao;

        #endregion


        //Construtor
        public DALUnidadeDeMedida(DALConexao cx)
        {
            this.conexao = cx;
        }


        public void Incluir(ModeloUnidadeDeMedida modelo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "INSERT INTO undmedida(umed_nome) VALUES (?nome); SELECT @@IDENTITY";
                cmd.Parameters.Add(new MySqlParameter("nome", modelo.UmedNome));

                conexao.Conectar();

                modelo.UmedCod = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public void Alterar(ModeloUnidadeDeMedida modelo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "UPDATE undmedida SET umed_nome = ?nome WHERE umed_cod = ?codigo;";
                cmd.Parameters.Add(new MySqlParameter("codigo", modelo.UmedCod));
                cmd.Parameters.Add(new MySqlParameter("nome", modelo.UmedNome));

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
                cmd.CommandText = "DELETE FROM undmedida WHERE umed_cod = ?codigo;";
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
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM undmedida WHERE umed_nome LIKE '%" + valor + "%' ORDER BY umed_cod ASC;", conexao.StringConexao);

                da.Fill(tabela);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tabela;
        }


        public ModeloUnidadeDeMedida CarregaModeloUnidadeDeMedida(int codigo)
        {
            ModeloUnidadeDeMedida modelo = new ModeloUnidadeDeMedida();

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "SELECT * FROM undmedida WHERE umed_cod = ?codigo";
                cmd.Parameters.Add(new MySqlParameter("codigo", codigo));

                conexao.Conectar();

                MySqlDataReader registro = cmd.ExecuteReader();

                if (registro.HasRows)
                {
                    registro.Read();

                    modelo.UmedCod = Convert.ToInt32(registro["umed_cod"]);
                    modelo.UmedNome = Convert.ToString(registro["umed_nome"]);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return modelo;
        }
    }
}
