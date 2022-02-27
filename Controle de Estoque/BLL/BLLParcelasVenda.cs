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
    public class BLLParcelasVenda
    {
        #region //Variaveis

        private DALConexao conexao;

        #endregion


        //Construtor
        public BLLParcelasVenda(DALConexao cx)
        {
            this.conexao = cx;
        }


        public void Incluir(ModeloParcelasVenda modelo)
        {
            try
            {
                if (modelo.PveCod <= 0)
                {
                    throw new Exception("O código da parcela deve ser informado!");
                }
                if (modelo.VenCod <= 0)
                {
                    throw new Exception("O código da venda deve ser informado!");
                }
                if (modelo.PveValor <= 0)
                {
                    throw new Exception("O valor da parcela deve ser informado!");
                }
                DateTime date = DateTime.Now;
                if (modelo.PveDataVecto.Year < date.Year)
                {
                    throw new Exception("Ano de vencimento inferior ao ano atual!");
                }

                DALParcelasVenda dalObj = new DALParcelasVenda(conexao);

                dalObj.Incluir(modelo);
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
                if (modelo.PveCod <= 0)
                {
                    throw new Exception("O código da parcela deve ser informado!");
                }
                if (modelo.VenCod <= 0)
                {
                    throw new Exception("O código da venda deve ser informado!");
                }
                if (modelo.PveValor <= 0)
                {
                    throw new Exception("O valor da parcela deve ser informado!");
                }
                DateTime date = DateTime.Now;
                if (modelo.PveDataVecto.Year < date.Year)
                {
                    throw new Exception("Ano de vencimento inferior ao ano atual!");
                }

                DALParcelasVenda dalObj = new DALParcelasVenda(conexao);

                dalObj.Alterar(modelo);
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
                if (modelo.PveCod <= 0)
                {
                    throw new Exception("O código da parcela deve ser informado!");
                }
                if (modelo.VenCod <= 0)
                {
                    throw new Exception("O código da venda deve ser informado!");
                }

                DALParcelasVenda dalObj = new DALParcelasVenda(conexao);

                dalObj.Excluir(modelo);
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
                if (vencod <= 0)
                {
                    throw new Exception("O código da venda deve ser informado!");
                }

                DALParcelasVenda dalObj = new DALParcelasVenda(conexao);

                dalObj.ExcluirTodasParcelas(vencod);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public DataTable Localizar(int vencod)
        {
            try
            {
                DALParcelasVenda dalObj = new DALParcelasVenda(conexao);

                return dalObj.Localizar(vencod);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public void CarregaModeloParcelasVenda(int pvecod, int vencod)
        {
            try
            {
                if (pvecod <= 0)
                {
                    throw new Exception("O código da parcela deve ser informado!");
                }
                if (vencod <= 0)
                {
                    throw new Exception("O código da venda deve ser informado!");
                }

                DALParcelasVenda dalObj = new DALParcelasVenda(conexao);

                dalObj.CarregaModeloParcelasVenda(pvecod, vencod);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
