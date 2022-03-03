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
    public class DALCliente
    {
        #region //Variaveis

        private DALConexao conexao;

        #endregion


        //Construtor
        public DALCliente(DALConexao cx)
        {
            this.conexao = cx;
        }


        public void Incluir(ModeloCliente modelo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "INSERT INTO cliente(cli_nome, cli_cpfcnpj, cli_rgie, cli_rsocial, cli_tipo, cli_cep, cli_endereco, cli_bairro, " +
                                                   "cli_fone, cli_cel, cli_email, cli_endnumero, cli_cidade, cli_estado) " +
                                                   "VALUES (?nome, ?cpfcnpj, ?rgie, ?rsocial, ?tipo, ?cep, ?endereco, ?bairro, ?fone, ?cel, ?email, ?endnumero, " +
                                                   "?cidade, ?estado); SELECT @@IDENTITY";
                cmd.Parameters.Add(new MySqlParameter("nome", modelo.CliNome));
                cmd.Parameters.Add(new MySqlParameter("cpfcnpj", modelo.CliCpfCnpj));
                cmd.Parameters.Add(new MySqlParameter("rgie", modelo.CliRgIe));
                cmd.Parameters.Add(new MySqlParameter("rsocial", modelo.CliRsocial));
                cmd.Parameters.Add(new MySqlParameter("tipo", modelo.CliTipo));
                cmd.Parameters.Add(new MySqlParameter("cep", modelo.CliCep));
                cmd.Parameters.Add(new MySqlParameter("endereco", modelo.CliEndereco));
                cmd.Parameters.Add(new MySqlParameter("bairro", modelo.CliBairro));
                cmd.Parameters.Add(new MySqlParameter("fone", modelo.CliFone));
                cmd.Parameters.Add(new MySqlParameter("cel", modelo.CliCel));
                cmd.Parameters.Add(new MySqlParameter("email", modelo.CliEmail));
                cmd.Parameters.Add(new MySqlParameter("endnumero", modelo.CliEndNumero));
                cmd.Parameters.Add(new MySqlParameter("cidade", modelo.CliCidade));
                cmd.Parameters.Add(new MySqlParameter("estado", modelo.CliEstado));

                conexao.Conectar();

                modelo.CliCod = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public void Alterar(ModeloCliente modelo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "UPDATE cliente SET cli_nome = ?nome, cli_cpfcnpj = ?cpfcnpj, cli_rgie = ?rgie, cli_rsocial = ?rsocial, cli_tipo = ?tipo, " +
                                  "cli_cep = ?cep, cli_endereco = ?endereco, cli_bairro = ?bairro, cli_fone = ?fone, cli_cel = ?cel, cli_email = ?email, " +
                                  "cli_endnumero = ?endnumero, cli_cidade = ?cidade, cli_estado = ?estado WHERE cli_cod = ?codigo;";
                cmd.Parameters.Add(new MySqlParameter("codigo", modelo.CliCod));
                cmd.Parameters.Add(new MySqlParameter("nome", modelo.CliNome));
                cmd.Parameters.Add(new MySqlParameter("cpfcnpj", modelo.CliCpfCnpj));
                cmd.Parameters.Add(new MySqlParameter("rgie", modelo.CliRgIe));
                cmd.Parameters.Add(new MySqlParameter("rsocial", modelo.CliRsocial));
                cmd.Parameters.Add(new MySqlParameter("tipo", modelo.CliTipo));
                cmd.Parameters.Add(new MySqlParameter("cep", modelo.CliCep));
                cmd.Parameters.Add(new MySqlParameter("endereco", modelo.CliEndereco));
                cmd.Parameters.Add(new MySqlParameter("bairro", modelo.CliBairro));
                cmd.Parameters.Add(new MySqlParameter("fone", modelo.CliFone));
                cmd.Parameters.Add(new MySqlParameter("cel", modelo.CliCel));
                cmd.Parameters.Add(new MySqlParameter("email", modelo.CliEmail));
                cmd.Parameters.Add(new MySqlParameter("endnumero", modelo.CliEndNumero));
                cmd.Parameters.Add(new MySqlParameter("cidade", modelo.CliCidade));
                cmd.Parameters.Add(new MySqlParameter("estado", modelo.CliEstado));

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
                cmd.CommandText = "DELETE FROM cliente WHERE cli_cod = ?codigo;";
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
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM cliente WHERE cli_nome LIKE '%" + valor + "%'", conexao.StringConexao);

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


        public DataTable LocalizarCPFCNPJ(string valor)
        {
            DataTable tabela = new DataTable();

            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM cliente WHERE cli_cpfcnpj LIKE '%" + valor + "%'", conexao.StringConexao);

                da.Fill(tabela);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tabela;
        }


        public ModeloCliente CarregaModeloCliente(int codigo)
        {
            ModeloCliente modelo = new ModeloCliente();

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "SELECT * FROM cliente WHERE cli_cod = ?codigo";
                cmd.Parameters.Add(new MySqlParameter("codigo", codigo));

                //conexao.Conectar();

                MySqlDataReader registro = cmd.ExecuteReader();

                if (registro.HasRows)
                {
                    registro.Read();

                    modelo.CliCod = Convert.ToInt32(registro["cli_cod"]);
                    modelo.CliNome = Convert.ToString(registro["cli_nome"]);
                    modelo.CliRsocial = Convert.ToString(registro["cli_rsocial"]);
                    modelo.CliCpfCnpj = Convert.ToString(registro["cli_cpfcnpj"]);
                    modelo.CliRgIe = Convert.ToString(registro["cli_rgie"]);
                    modelo.CliTipo = Convert.ToInt32(registro["cli_tipo"]);
                    modelo.CliCep = Convert.ToString(registro["cli_cep"]);
                    modelo.CliCel = Convert.ToString(registro["cli_cel"]);
                    modelo.CliEndereco = Convert.ToString(registro["cli_endereco"]);
                    modelo.CliBairro = Convert.ToString(registro["cli_bairro"]);
                    modelo.CliFone = Convert.ToString(registro["cli_fone"]);
                    modelo.CliEmail = Convert.ToString(registro["cli_email"]);
                    modelo.CliEndNumero = Convert.ToInt32(registro["cli_endnumero"]);
                    modelo.CliCidade = Convert.ToString(registro["cli_cidade"]);
                    modelo.CliEstado = Convert.ToString(registro["cli_estado"]);
                }

                registro.Close();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return modelo;
        }


        public ModeloCliente CarregaModeloCliente(string cpfCnpj)
        {
            ModeloCliente modelo = new ModeloCliente();

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "SELECT * FROM cliente WHERE cli_cpfcnpj = ?cpfcnpj";
                cmd.Parameters.Add(new MySqlParameter("cpfcnpj", cpfCnpj));

                conexao.Conectar();

                MySqlDataReader registro = cmd.ExecuteReader();

                if (registro.HasRows)
                {
                    registro.Read();

                    modelo.CliCod = Convert.ToInt32(registro["cli_cod"]);
                    modelo.CliNome = Convert.ToString(registro["cli_nome"]);
                    modelo.CliCpfCnpj = Convert.ToString(registro["cli_cpfcnpj"]);
                    modelo.CliRgIe = Convert.ToString(registro["cli_rgie"]);
                    modelo.CliTipo = Convert.ToInt32(registro["cli_tipo"]);
                    modelo.CliCep = Convert.ToString(registro["cli_cep"]);
                    modelo.CliCel = Convert.ToString(registro["cli_cel"]);
                    modelo.CliEndereco = Convert.ToString(registro["cli_endereco"]);
                    modelo.CliBairro = Convert.ToString(registro["cli_bairro"]);
                    modelo.CliFone = Convert.ToString(registro["cli_fone"]);
                    modelo.CliEmail = Convert.ToString(registro["cli_email"]);
                    modelo.CliEndNumero = Convert.ToInt32(registro["cli_endnumero"]);
                    modelo.CliCidade = Convert.ToString(registro["cli_cidade"]);
                    modelo.CliEstado = Convert.ToString(registro["cli_estado"]);
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
