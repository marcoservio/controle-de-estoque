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
    public class DALParcelasVenda
    {
        #region //Variaveis

        private DALConexao conexao;

        #endregion


        //Construtor
        public DALParcelasVenda(DALConexao cx)
        {
            this.conexao = cx;
        }


        public void Incluir(ModeloParcelasVenda modelo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "INSERT INTO parcelasvenda(pve_cod, pve_valor, pve_datavecto, ven_cod)  VALUES (?pvecod,  ?pvevalor, ?pvedatavecto, ?vencod);";
                cmd.Parameters.Add(new MySqlParameter("pvecod", modelo.PveCod));
                cmd.Parameters.Add(new MySqlParameter("pvevalor", modelo.PveValor));
                cmd.Parameters.Add(new MySqlParameter("vencod", modelo.VenCod));
                cmd.Parameters.Add("pvedatavecto", MySqlDbType.Date);
                if (modelo.PveDataVecto == null)
                {
                    cmd.Parameters["pvedatavecto"].Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters["pvedatavecto"].Value = modelo.PveDataVecto;
                }

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public void Alterar(ModeloParcelasVenda modelo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "UPDATE parcelasvenda SET pve_valor = ?pvevalor, pve_datapagto = ?pvedatapagto, pve_datavecto = ?pvedatavecto WHERE pve_cod = ?pvecod AND ven_cod = ?vencod;";
                cmd.Parameters.Add(new MySqlParameter("pvecod", modelo.PveCod));
                cmd.Parameters.Add(new MySqlParameter("pvevalor", modelo.PveValor));
                cmd.Parameters.Add(new MySqlParameter("vencod", modelo.VenCod));
                cmd.Parameters.Add("pvedatapagto", MySqlDbType.Date);
                if (modelo.PveDataVecto == null)
                {
                    cmd.Parameters["pvedatavecto"].Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters["pvedatavecto"].Value = modelo.PveDataVecto;
                }

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public void Excluir(ModeloParcelasVenda modelo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "DELETE FROM parcelasvenda WHERE pve_cod = ?pvecod AND ven_cod = ?vencod;";
                cmd.Parameters.Add(new MySqlParameter("pvecod", modelo.PveCod));
                cmd.Parameters.Add(new MySqlParameter("vencod", modelo.VenCod));

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public void ExcluirTodasParcelas(int vencod)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "DELETE FROM parcelasvenda WHERE ven_cod = ?vencod;";
                cmd.Parameters.Add(new MySqlParameter("vencod", vencod));

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public DataTable Localizar(int vencod)
        {
            DataTable tabela = new DataTable();

            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM parcelasvenda WHERE ven_cod = " + vencod.ToString(), conexao.StringConexao);

                da.Fill(tabela);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tabela;
        }


        public ModeloParcelasVenda CarregaModeloParcelasVenda(int pvecod, int vencod)
        {
            ModeloParcelasVenda modelo = new ModeloParcelasVenda();

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "SELECT * FROM parcelasvenda WHERE pvecod = ?pvecod AND ven_cod = ?vencod";
                cmd.Parameters.Add(new MySqlParameter("pvecod", pvecod));
                cmd.Parameters.Add(new MySqlParameter("vencod", vencod));

                conexao.Conectar();

                MySqlDataReader registro = cmd.ExecuteReader();

                if (registro.HasRows)
                {
                    registro.Read();

                    modelo.PveCod = pvecod;
                    modelo.VenCod = vencod;
                    modelo.PveDataPagto = Convert.ToDateTime(registro["pve_datapagto"]);
                    modelo.PveDataVecto = Convert.ToDateTime(registro["pve_datavecto"]);
                    modelo.PveValor = Convert.ToDouble(registro["pve_valor"]);
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
