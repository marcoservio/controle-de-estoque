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
    public class DALParcelasCompra
    {
        #region //Variaveis

        private DALConexao conexao;

        #endregion


        //Construtor
        public DALParcelasCompra(DALConexao cx)
        {
            this.conexao = cx;
        }


        public void Incluir(ModeloParcelasCompra modelo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "INSERT INTO parcelascompra(pco_cod, pco_valor, pco_datavecto, com_cod) VALUES (?pcocod,  ?pcovalor, ?pcodatavecto, ?comcod);";
                cmd.Parameters.Add(new MySqlParameter("pcocod", modelo.PcoCod));
                cmd.Parameters.Add(new MySqlParameter("pcovalor", modelo.PcoValor));
                cmd.Parameters.Add(new MySqlParameter("comcod", modelo.ComCod));
                cmd.Parameters.Add("pcodatavecto", MySqlDbType.Date);
                cmd.Parameters["pcodatavecto"].Value = modelo.PcoDataVecto;

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public void Alterar(ModeloParcelasCompra modelo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "UPDATE parcelascompra SET pco_valor = ?pcovalor, pco_datapagto = ?pcodatapagto, pco_datavecto = ?pcodatavecto WHERE pco_cod = ?pcocod AND com_cod = ?comcod;";
                cmd.Parameters.Add(new MySqlParameter("pcocod", modelo.PcoCod));
                cmd.Parameters.Add(new MySqlParameter("pcovalor", modelo.PcoValor));
                cmd.Parameters.Add(new MySqlParameter("comcod", modelo.ComCod));
                cmd.Parameters.Add("pcodatapagto", MySqlDbType.Date);
                cmd.Parameters.Add("pcodatavecto", MySqlDbType.Date);
                if (modelo.PcoDataPagto == null)
                {
                    cmd.Parameters["pcodatapagto"].Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters["pcodatapagto"].Value = modelo.PcoDataPagto;
                }
                cmd.Parameters["pcodatavecto"].Value = modelo.PcoDataVecto;

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public void Excluir(ModeloParcelasCompra modelo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                conexao.ObjetoConexao = new MySqlConnection(conexao.StringConexao);
                cmd.CommandText = "DELETE FROM parcelascompra WHERE pco_cod = ?pcocod AND com_cod = ?comcod;";
                cmd.Parameters.Add(new MySqlParameter("pcocod", modelo.PcoCod));
                cmd.Parameters.Add(new MySqlParameter("comcod", modelo.ComCod));

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public void ExcluirTodasParcelas(int comcod)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "DELETE FROM parcelascompra WHERE com_cod = ?comcod;";
                cmd.Parameters.Add(new MySqlParameter("comcod", comcod));

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public DataTable Localizar(int comcod)
        {
            DataTable tabela = new DataTable();

            try
            {
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM parcelascompra WHERE com_cod = " + comcod.ToString() + " ORDER BY pco_cod;", conexao.StringConexao);

                da.Fill(tabela);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tabela;
        }


        public ModeloParcelasCompra CarregaModeloItensCompra(int pcocod, int comcod)
        {
            ModeloParcelasCompra modelo = new ModeloParcelasCompra();

            try
            {
                conexao.ObjetoConexao = new MySqlConnection(conexao.StringConexao);
                string mSQL = "SELECT * FROM parcelascompra WHERE pcocod = ?pcocod AND com_cod = ?comcod";
                MySqlCommand cmd = new MySqlCommand(mSQL, conexao.ObjetoConexao);
                cmd.Parameters.Add(new MySqlParameter("pcocod", pcocod));
                cmd.Parameters.Add(new MySqlParameter("comcod", comcod));

                conexao.Conectar();

                MySqlDataReader registro = cmd.ExecuteReader();

                if (registro.HasRows)
                {
                    registro.Read();

                    modelo.PcoCod = pcocod;
                    modelo.ComCod = comcod;
                    modelo.PcoDataPagto = Convert.ToDateTime(registro["pco_datapagto"]);
                    modelo.PcoDataVecto = Convert.ToDateTime(registro["pco_datavecto"]);
                    modelo.PcoValor = Convert.ToDouble(registro["pco_valor"]);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return modelo;
        }


        public void EfetuarPagamento(int comcod, int pcocod, DateTime dtpagto)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "UPDATE parcelascompra SET pco_datapagto = ?pcodatapagto WHERE pco_cod = ?pcocod AND com_cod = ?comcod;";
                cmd.Parameters.Add(new MySqlParameter("pcocod", pcocod));
                cmd.Parameters.Add(new MySqlParameter("comcod", comcod));
                cmd.Parameters.Add("pcodatapagto", MySqlDbType.Date);
                cmd.Parameters["pcodatapagto"].Value = dtpagto;

                conexao.Conectar();

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
