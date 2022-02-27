using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace DAL
{
    public class DALConexao
    {
        #region //Variaveis

        private string _stringConexao;
        private MySqlConnection _conexao;
        private MySqlTransaction _transaction;

        #endregion


        //Construtor
        public DALConexao(string dadosConexao)
        {
            this._conexao = new MySqlConnection();
            this._stringConexao = dadosConexao;
            this._conexao.ConnectionString = dadosConexao;
        }


        #region //Encapsulamento das variaveis

        public string StringConexao
        {
            get { return _stringConexao; }
            set { _stringConexao = value; }
        }
        public MySqlConnection ObjetoConexao
        {
            get { return _conexao; }
            set { _conexao = value; }
        }
        public MySqlTransaction ObjetoTransacao
        {
            get { return _transaction; }
            set { _transaction = value; }
        }

        #endregion


        public void IniciarTransacao()
        {
            this._transaction = _conexao.BeginTransaction();
        }


        public void CancelarTransacao()
        {
            this._transaction.Rollback();
        }


        public void TerminarTransacao()
        {
            this._transaction.Commit();
        }


        public void Conectar()
        {
            this._conexao.Open();
        }


        public void Desconectar()
        {
            this._conexao.Close();
        }
    }
}
