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
    public class DALFornecedor
    {
        #region //Variaveis

        private DALConexao conexao;

        #endregion


        //Construtor
        public DALFornecedor(DALConexao cx)
        {
            this.conexao = cx;
        }


        public void Incluir(ModeloFornecedor modelo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "INSERT INTO fornecedor(for_nome, for_rsocial, for_cnpj, for_ie, for_cep, for_endereco, for_bairro, " +
                                                         "for_fone, for_cel, for_email, for_endnumero, for_cidade, for_estado) " +
                                                         "VALUES (?nome, ?rsocial, ?cnpj, ?ie, ?cep, ?endereco, ?bairro, ?fone, ?cel, ?email, ?endnumero, " +
                                                         "?cidade, ?estado); SELECT @@IDENTITY";
                cmd.Parameters.Add(new MySqlParameter("nome", modelo.ForNome));
                cmd.Parameters.Add(new MySqlParameter("rsocial", modelo.ForRsocial));
                cmd.Parameters.Add(new MySqlParameter("cnpj", modelo.ForCnpj));
                cmd.Parameters.Add(new MySqlParameter("ie", modelo.ForIe));
                cmd.Parameters.Add(new MySqlParameter("cep", modelo.ForCep));
                cmd.Parameters.Add(new MySqlParameter("endereco", modelo.ForEndereco));
                cmd.Parameters.Add(new MySqlParameter("bairro", modelo.ForBairro));
                cmd.Parameters.Add(new MySqlParameter("fone", modelo.ForFone));
                cmd.Parameters.Add(new MySqlParameter("cel", modelo.ForCel));
                cmd.Parameters.Add(new MySqlParameter("email", modelo.ForEmail));
                cmd.Parameters.Add(new MySqlParameter("endnumero", modelo.ForEndNumero));
                cmd.Parameters.Add(new MySqlParameter("cidade", modelo.ForCidade));
                cmd.Parameters.Add(new MySqlParameter("estado", modelo.ForEstado));

                conexao.Conectar();

                modelo.ForCod = Convert.ToInt32(cmd.ExecuteScalar());
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


        public void Alterar(ModeloFornecedor modelo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "UPDATE fornecedor SET for_nome = ?nome,  for_rsocial = ?rsocial, for_cnpj = ?cnpj, for_ie = ?ie, " +
                                  "for_cep = ?cep, for_endereco = ?endereco, for_bairro = ?bairro, for_fone = ?fone, for_cel = ?cel, for_email = ?email, " +
                                  "for_endnumero = ?endnumero, for_cidade = ?cidade, for_estado = ?estado WHERE for_cod = ?codigo;";
                cmd.Parameters.Add(new MySqlParameter("codigo", modelo.ForCod));
                cmd.Parameters.Add(new MySqlParameter("nome", modelo.ForNome));
                cmd.Parameters.Add(new MySqlParameter("rsocial", modelo.ForRsocial));
                cmd.Parameters.Add(new MySqlParameter("cnpj", modelo.ForCnpj));
                cmd.Parameters.Add(new MySqlParameter("ie", modelo.ForIe));
                cmd.Parameters.Add(new MySqlParameter("cep", modelo.ForCep));
                cmd.Parameters.Add(new MySqlParameter("endereco", modelo.ForEndereco));
                cmd.Parameters.Add(new MySqlParameter("bairro", modelo.ForBairro));
                cmd.Parameters.Add(new MySqlParameter("fone", modelo.ForFone));
                cmd.Parameters.Add(new MySqlParameter("cel", modelo.ForCel));
                cmd.Parameters.Add(new MySqlParameter("email", modelo.ForEmail));
                cmd.Parameters.Add(new MySqlParameter("endnumero", modelo.ForEndNumero));
                cmd.Parameters.Add(new MySqlParameter("cidade", modelo.ForCidade));
                cmd.Parameters.Add(new MySqlParameter("estado", modelo.ForEstado));

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
                cmd.CommandText = "DELETE FROM fornecedor WHERE for_cod = ?codigo;";
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
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM fornecedor WHERE for_nome LIKE '%" + valor + "%'", conexao.StringConexao);

                da.Fill(tabela);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tabela;
        }


        public DataTable LocalizarNome(string valor)
        {
            return Localizar(valor);
        }


        public DataTable LocalizarCNPJ(string valor)
        {
            DataTable tabela = new DataTable();

            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM fornecedor WHERE for_cnpj LIKE '%" + valor + "%'", conexao.StringConexao);

                da.Fill(tabela);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tabela;
        }


        public ModeloFornecedor CarregaModeloFornecedor(int codigo)
        {
            ModeloFornecedor modelo = new ModeloFornecedor();

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "SELECT * FROM fornecedor WHERE for_cod = ?codigo";
                cmd.Parameters.Add(new MySqlParameter("codigo", codigo));

                conexao.Conectar();

                MySqlDataReader registro = cmd.ExecuteReader();

                if (registro.HasRows)
                {
                    registro.Read();

                    modelo.ForCod = Convert.ToInt32(registro["for_cod"]);
                    modelo.ForNome = Convert.ToString(registro["for_nome"]);
                    modelo.ForRsocial = Convert.ToString(registro["for_rsocial"]);
                    modelo.ForCnpj = Convert.ToString(registro["for_cnpj"]);
                    modelo.ForIe = Convert.ToString(registro["for_ie"]);
                    modelo.ForCep = Convert.ToString(registro["for_cep"]);
                    modelo.ForCel = Convert.ToString(registro["for_cel"]);
                    modelo.ForEndereco = Convert.ToString(registro["for_endereco"]);
                    modelo.ForBairro = Convert.ToString(registro["for_bairro"]);
                    modelo.ForFone = Convert.ToString(registro["for_fone"]);
                    modelo.ForEmail = Convert.ToString(registro["for_email"]);
                    modelo.ForEndNumero = Convert.ToInt32(registro["for_endnumero"]);
                    modelo.ForCidade = Convert.ToString(registro["for_cidade"]);
                    modelo.ForEstado = Convert.ToString(registro["for_estado"]);
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


        public ModeloFornecedor CarregaModeloFornecedor(string cpfcnpj)
        {
            ModeloFornecedor modelo = new ModeloFornecedor();

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "SELECT * FROM fornecedor WHERE for_cnpj = ?cnpj";
                cmd.Parameters.Add(new MySqlParameter("cnpj", cpfcnpj));

                conexao.Conectar();

                MySqlDataReader registro = cmd.ExecuteReader();

                if (registro.HasRows)
                {
                    registro.Read();

                    modelo.ForCod = Convert.ToInt32(registro["for_cod"]);
                    modelo.ForNome = Convert.ToString(registro["for_nome"]);
                    modelo.ForCnpj = Convert.ToString(registro["for_cnpj"]);
                    modelo.ForIe = Convert.ToString(registro["for_ie"]);
                    modelo.ForCep = Convert.ToString(registro["for_cep"]);
                    modelo.ForCel = Convert.ToString(registro["for_cel"]);
                    modelo.ForEndereco = Convert.ToString(registro["for_endereco"]);
                    modelo.ForBairro = Convert.ToString(registro["for_bairro"]);
                    modelo.ForFone = Convert.ToString(registro["for_fone"]);
                    modelo.ForEmail = Convert.ToString(registro["for_email"]);
                    modelo.ForEndNumero = Convert.ToInt32(registro["for_endnumero"]);
                    modelo.ForCidade = Convert.ToString(registro["for_cidade"]);
                    modelo.ForEstado = Convert.ToString(registro["for_estado"]);
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
