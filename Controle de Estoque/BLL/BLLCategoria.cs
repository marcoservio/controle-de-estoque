using DAL;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL
{
    public class BLLCategoria
    {
        #region //Variaveis

        private DALConexao conexao;

        #endregion


        //Construtor
        public BLLCategoria(DALConexao cx)
        {
            this.conexao = cx;
        }


        public void Incluir(ModeloCategoria modelo)
        {
            try
            {
                if (modelo.CatNome.Trim().Length == 0)
                {
                    throw new Exception("O nome da categoria é obrigatorio!");
                }

                DALCategoria dalObj = new DALCategoria(conexao);

                dalObj.Incluir(modelo);
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
                if (modelo.CatCod <= 0)
                {
                    throw new Exception("O código da categoria é obrigatório!");
                }

                if (modelo.CatNome.Trim().Length == 0)
                {
                    throw new Exception("O nome da categoria é obrigatorio!");
                }

                DALCategoria dalObj = new DALCategoria(conexao);

                dalObj.Alterar(modelo);
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
                if (codigo <= 0)
                {
                    throw new Exception("O código deve ser informado!");
                }

                DALCategoria dalObj = new DALCategoria(conexao);

                dalObj.Excluir(codigo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }


        public DataTable Localizar(string valor)
        {
            try
            {
                DALCategoria dalObj = new DALCategoria(conexao);

                return dalObj.Localizar(valor);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }


        public ModeloCategoria CarregaModeloCategoria(int codigo)
        {
            try
            {
                if (codigo <= 0)
                {
                    throw new Exception("O código deve ser informado!");
                }

                DALCategoria dalObj = new DALCategoria(conexao);

                return dalObj.CarregaModeloCategoria(codigo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
