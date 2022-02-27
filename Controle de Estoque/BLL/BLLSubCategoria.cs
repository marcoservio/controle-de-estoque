using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using DAL;
using System.Data;


namespace BLL
{
    public class BLLSubCategoria
    {
        #region //Variaveis

        private DALConexao conexao;

        #endregion


        //Construtor
        public BLLSubCategoria(DALConexao cx)
        {
            this.conexao = cx;
        }


        public void Incluir(ModeloSubCategoria modelo)
        {
            try
            {
                if (modelo.ScatNome.Trim().Length == 0)
                {
                    throw new Exception("O nome da SubCategoria deve ser informado!");
                }
                if (modelo.CatCod <= 0)
                {
                    throw new Exception("O codigo da SubCategoria deve ser informado!");
                }

                DALSubCategoria dalObj = new DALSubCategoria(conexao);

                dalObj.Incluir(modelo);
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
                if (modelo.ScatCod <= 0)
                {
                    throw new Exception("O código da SubCategoria deve ser informado!");
                }
                if (modelo.ScatNome.Trim().Length == 0)
                {
                    throw new Exception("O nome da SubCategoria deve ser informado!");
                }
                if (modelo.CatCod <= 0)
                {
                    throw new Exception("O codigo da categoria deve ser informado!");
                }

                DALSubCategoria dalObj = new DALSubCategoria(conexao);

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
                    throw new Exception("O codigo deve ser informado!");
                }

                DALSubCategoria dalObj = new DALSubCategoria(conexao);

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
                DALSubCategoria dalObj = new DALSubCategoria(conexao);

                return dalObj.Localizar(valor);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public DataTable LocalizarPorCategoria(int cod)
        {
            try
            {
                DALSubCategoria dalObj = new DALSubCategoria(conexao);

                return dalObj.LocalizarPorCategoria(cod);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public ModeloSubCategoria CarregaModeloCategoria(int codigo)
        {
            try
            {
                if (codigo <= 0)
                {
                    throw new Exception("O codigo deve ser informado!");
                }

                DALSubCategoria dalObj = new DALSubCategoria(conexao);

                return dalObj.CarregaModeloSubCategoria(codigo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
