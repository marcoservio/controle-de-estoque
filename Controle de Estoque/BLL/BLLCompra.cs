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
    public class BLLCompra
    {
        #region //Variaveis

        private DALConexao conexao;

        #endregion


        //Construtor
        public BLLCompra(DALConexao cx)
        {
            this.conexao = cx;
        }


        public void Incluir(ModeloCompra modelo)
        {
            try
            {
                if (modelo.ComNparcelas <= 0)
                {
                    throw new Exception("O número de parcelas deve ser maior do que zero!");
                }
                if (modelo.ForCod <= 0)
                {
                    throw new Exception("O código do fornecedor deve ser informado!");
                }
                if (modelo.ComTotal <= 0)
                {
                    throw new Exception("O valor da compra deve ser informado!");
                }

                DALCompra dalObj = new DALCompra(conexao);

                dalObj.Incluir(modelo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public void Alterar(ModeloCompra modelo)
        {
            try
            {
                if (modelo.ComCod <= 0)
                {
                    throw new Exception("O código da comprar deve ser maior do que zero!");
                }
                if (modelo.ComNparcelas <= 0)
                {
                    throw new Exception("O número de parcelas deve ser maior do que zero!");
                }
                if (modelo.ForCod <= 0)
                {
                    throw new Exception("O código do fornecedor deve ser informado!");
                }
                if (modelo.ComTotal <= 0)
                {
                    throw new Exception("O valor da compra deve ser informado!");
                }

                DALCompra dalObj = new DALCompra(conexao);

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

                DALCompra dalObj = new DALCompra(conexao);

                dalObj.Excluir(codigo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        //Localiar por código do fornecedor
        public DataTable Localizar(int valor)
        {
            try
            {
                DALCompra dalObj = new DALCompra(conexao);

                return dalObj.Localizar(valor);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        //Localiar por nome do fornecedor
        public DataTable Localizar(string nome)
        {
            try
            {
                DALCompra dalObj = new DALCompra(conexao);

                return dalObj.Localizar(nome);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        //Localizar todas as compra
        public DataTable Localizar()
        {
            try
            {
                DALCompra dalObj = new DALCompra(conexao);

                return dalObj.Localizar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        //Localizar pro data
        public DataTable Localizar(DateTime dtinicial, DateTime dtfinal)
        {
            try
            {
                DALCompra dalObj = new DALCompra(conexao);

                return dalObj.Localizar(dtinicial, dtfinal);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        //Localizar por Parcelas em Aberto
        public DataTable LocalizarParcelasEmAberto()
        {
            try
            {
                DALCompra dalObj = new DALCompra(conexao);

                return dalObj.LocalizarParcelasEmAberto();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public int QuantidadeParcelasNãoPagas(int codigo)
        {
            try
            {
                if (codigo <= 0)
                {
                    throw new Exception("O código deve ser informado!");
                }

                DALCompra dalObj = new DALCompra(conexao);
                return dalObj.QuantidadeParcelasNãoPagas(codigo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public ModeloCompra CarregaModeloCompra(int codigo)
        {
            try
            {
                if (codigo <= 0)
                {
                    throw new Exception("O código deve ser informado!");
                }

                DALCompra dalObj = new DALCompra(conexao);

                return dalObj.CarregaModeloCompra(codigo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
