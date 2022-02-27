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
    public class DALSubCategoria
    {
        #region //Variaveis

        private DALConexao conexao;

        #endregion


        //Construtor
        public DALSubCategoria(DALConexao cx)
        {
            this.conexao = cx;
        }


        public void Incluir(ModeloSubCategoria modelo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "INSERT INTO subcategoria(cat_cod, scat_nome) VALUES (?codigo, ?snome); SELECT @@IDENTITY";
                cmd.Parameters.Add(new MySqlParameter("codigo", modelo.CatCod));
                cmd.Parameters.Add(new MySqlParameter("snome", modelo.ScatNome));

                conexao.Conectar();

                modelo.ScatCod = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public void Alterar(ModeloSubCategoria modelo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "UPDATE subcategoria SET scat_nome = ?snome, cat_cod = ?codigo WHERE scat_cod = ?scodigo;";
                cmd.Parameters.Add(new MySqlParameter("codigo", modelo.CatCod));
                cmd.Parameters.Add(new MySqlParameter("snome", modelo.ScatNome));
                cmd.Parameters.Add(new MySqlParameter("scodigo", modelo.ScatCod));

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
                cmd.CommandText = "DELETE FROM subcategoria WHERE scat_cod = ?codigo;";
                cmd.Parameters.Add(new MySqlParameter("codigo", codigo));

                conexao.Conectar();

                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw new Exception("Esse registro está sendo utilizado na tabela de produtos!");
            }
        }


        public DataTable Localizar(string valor)
        {
            DataTable tabela = new DataTable();

            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT sc.scat_cod, sc.scat_nome, c.cat_cod, c.cat_nome FROM subcategoria sc INNER JOIN categoria c ON sc.cat_cod = c.cat_cod AND sc.scat_nome LIKE '%" + valor + "%'", conexao.StringConexao);

                da.Fill(tabela);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tabela;
        }


        public DataTable LocalizarPorCategoria(int cod)
        {
            DataTable tabela = new DataTable();

            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT sc.scat_cod, sc.scat_nome, c.cat_cod, c.cat_nome FROM subcategoria sc INNER JOIN categoria c ON sc.cat_cod = c.cat_cod WHERE sc.cat_cod = " + cod.ToString(), conexao.StringConexao);

                da.Fill(tabela);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tabela;
        }


        public ModeloSubCategoria CarregaModeloSubCategoria(int codigo)
        {
            ModeloSubCategoria modelo = new ModeloSubCategoria();

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "SELECT * FROM subcategoria WHERE scat_cod = ?codigo";
                cmd.Parameters.Add(new MySqlParameter("codigo", codigo));

                conexao.Conectar();

                MySqlDataReader registro = cmd.ExecuteReader();

                if (registro.HasRows)
                {
                    registro.Read();

                    modelo.ScatCod = Convert.ToInt32(registro["scat_cod"]);
                    modelo.ScatNome = Convert.ToString(registro["scat_nome"]);
                    modelo.CatCod = Convert.ToInt32(registro["cat_cod"]);
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
