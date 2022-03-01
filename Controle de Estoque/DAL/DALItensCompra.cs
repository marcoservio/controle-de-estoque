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
    public class DALItensCompra
    {
        #region //Variaveis

        private DALConexao conexao;

        #endregion


        //Construtor
        public DALItensCompra(DALConexao cx)
        {
            this.conexao = cx;
        }


        public void Incluir(ModeloItensCompra modelo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "INSERT INTO itenscompra(itc_cod, itc_qtde, itc_valor, com_cod, pro_cod) VALUES (?itccod,  ?itcqtde, ?itcvalor, ?comcod, ?procod);";
                cmd.Parameters.Add(new MySqlParameter("itccod", modelo.ItcCod));
                cmd.Parameters.Add(new MySqlParameter("itcqtde", modelo.ItcQtde));
                cmd.Parameters.Add(new MySqlParameter("itcvalor", modelo.ItcValor));
                cmd.Parameters.Add(new MySqlParameter("comcod", modelo.ComCod));
                cmd.Parameters.Add(new MySqlParameter("procod", modelo.ProCod));

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public void Alterar(ModeloItensCompra modelo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "UPDATE itenscompra SET itc_qtde = ?itcqtde, itc_valor = ?itcvalor WHERE itc_cod = ?itccod AND com_cod = ?comcod AND pro_cod = ?procod;";
                cmd.Parameters.Add(new MySqlParameter("itccod", modelo.ItcCod));
                cmd.Parameters.Add(new MySqlParameter("itcqtde", modelo.ItcQtde));
                cmd.Parameters.Add(new MySqlParameter("itcvalor", modelo.ItcValor));
                cmd.Parameters.Add(new MySqlParameter("comcod", modelo.ComCod));
                cmd.Parameters.Add(new MySqlParameter("procod", modelo.ProCod));

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public void Excluir(ModeloItensCompra modelo)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "DELETE FROM itenscompra WHERE itc_cod = ?itccod AND com_cod = ?comcod AND pro_cod = ?procod";
                cmd.Parameters.Add(new MySqlParameter("itccod", modelo.ItcCod));
                cmd.Parameters.Add(new MySqlParameter("comcod", modelo.ComCod));
                cmd.Parameters.Add(new MySqlParameter("procod", modelo.ProCod));

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public void ExcluirTodosItens(int comcod)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.Transaction = conexao.ObjetoTransacao;
                cmd.CommandText = "DELETE FROM itenscompra WHERE com_cod = ?comcod";
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
                MySqlDataAdapter da = new MySqlDataAdapter("SELECT i.*, p.pro_nome FROM itenscompra i INNER JOIN produto p ON i.pro_cod = p.pro_cod AND com_cod = " + comcod.ToString(), conexao.StringConexao);

                da.Fill(tabela);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tabela;
        }


        public ModeloItensCompra CarregaModeloItensCompra(int itccod, int comcod, int procod)
        {
            ModeloItensCompra modelo = new ModeloItensCompra();

            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao.ObjetoConexao;
                cmd.CommandText = "SELECT * FROM itenscompra WHERE itc_cod = ?itccod AND com_cod = ?comcod AND pro_cod = ?procod";
                cmd.Parameters.Add(new MySqlParameter("itccod", itccod));
                cmd.Parameters.Add(new MySqlParameter("comcod", comcod));
                cmd.Parameters.Add(new MySqlParameter("procod", procod));

                conexao.Conectar();

                MySqlDataReader registro = cmd.ExecuteReader();

                if (registro.HasRows)
                {
                    registro.Read();

                    modelo.ItcCod = itccod;
                    modelo.ItcValor = Convert.ToDouble(registro["itc_valor"]);
                    modelo.ItcQtde = Convert.ToInt32(registro["itc_qtde"]);
                    modelo.ComCod = comcod;
                    modelo.ProCod = procod;
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
