using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using DAL;
using BLL;
using System.Data;


namespace BLL
{
    public class BLLTipoPagamento
    {
        #region //Variaveis

        private DALConexao conexao;

        #endregion


        //Construtor
        public BLLTipoPagamento(DALConexao cx)
        {
            this.conexao = cx;
        }


        public void Incluir(ModeloTipoPagamento modelo)
        {
            try
            {
                if (modelo.TpaNome.Trim().Length == 0)
                {
                    throw new Exception("O tipo de pagamento deve ser informado!");
                }

                DALTipoPagamento dalObj = new DALTipoPagamento(conexao);

                dalObj.Incluir(modelo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public void Alterar(ModeloTipoPagamento modelo)
        {
            try
            {
                if (modelo.TpaCod <= 0)
                {
                    throw new Exception("O código do tipo de pagamento deve ser informado!");
                }

                if (modelo.TpaNome.Trim().Length == 0)
                {
                    throw new Exception("O tipo de pagamento deve ser informado!");
                }

                DALTipoPagamento dalObj = new DALTipoPagamento(conexao);

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

                DALTipoPagamento dalObj = new DALTipoPagamento(conexao);

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
                DALTipoPagamento dalObj = new DALTipoPagamento(conexao);

                return dalObj.Localizar(valor);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public ModeloTipoPagamento CarregaModeloTipoPagamento(int codigo)
        {
            try
            {
                if (codigo <= 0)
                {
                    throw new Exception("O código deve ser informado!");
                }

                DALTipoPagamento dalObj = new DALTipoPagamento(conexao);

                return dalObj.CarregaModeloTipoPagamento(codigo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
