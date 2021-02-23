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
    public class BLLParcelasCompras
    {
        #region //Variaveis

        private DALConexao conexao;

        #endregion


        //Construtor
        public BLLParcelasCompras(DALConexao cx)
        {
            this.conexao = cx;
        }


        public void Incluir(ModeloParcelasCompra modelo)
        {
            try
            {
                if (modelo.PcoCod <= 0)
                {
                    throw new Exception("O código da parcela deve ser informado!");
                }
                if (modelo.ComCod <= 0)
                {
                    throw new Exception("O código da compra deve ser informado!");
                }
                if (modelo.PcoValor <= 0)
                {
                    throw new Exception("O valor da parcela deve ser informado!");
                }
                DateTime date = DateTime.Now;
                if (modelo.PcoDataVecto.Year < date.Year)
                {
                    throw new Exception("Ano de vencimento inferior ao ano atual!");
                }

                DALParcelasCompra dalObj = new DALParcelasCompra(conexao);

                dalObj.Incluir(modelo);
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
                if (modelo.PcoCod <= 0)
                {
                    throw new Exception("O código da parcela deve ser informado!");
                }
                if (modelo.ComCod <= 0)
                {
                    throw new Exception("O código da compra deve ser informado!");
                }
                if (modelo.PcoValor <= 0)
                {
                    throw new Exception("O valor da parcela deve ser informado!");
                }
                DateTime date = DateTime.Now;
                if (modelo.PcoDataVecto.Year < date.Year)
                {
                    throw new Exception("Ano de vencimento inferior ao ano atual!");
                }

                DALParcelasCompra dalObj = new DALParcelasCompra(conexao);

                dalObj.Alterar(modelo);
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
                if (modelo.PcoCod <= 0)
                {
                    throw new Exception("O código da parcela deve ser informado!");
                }
                if (modelo.ComCod <= 0)
                {
                    throw new Exception("O código da compra deve ser informado!");
                }

                DALParcelasCompra dalObj = new DALParcelasCompra(conexao);

                dalObj.Excluir(modelo);
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
                if (comcod <= 0)
                {
                    throw new Exception("O código da compra deve ser informado!");
                }

                DALParcelasCompra dalObj = new DALParcelasCompra(conexao);

                dalObj.ExcluirTodasParcelas(comcod);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public DataTable Localizar(int comcod)
        {
            try
            {
                DALParcelasCompra dalObj = new DALParcelasCompra(conexao);

                return dalObj.Localizar(comcod);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public void CarregaModeloParcelasCompra(int pcocod, int comcod)
        {
            try
            {
                if (pcocod <= 0)
                {
                    throw new Exception("O código da parcela deve ser informado!");
                }
                if (comcod <= 0)
                {
                    throw new Exception("O código da compra deve ser informado!");
                }

                DALParcelasCompra dalObj = new DALParcelasCompra(conexao);

                dalObj.CarregaModeloItensCompra(pcocod, comcod);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public void EfetuarPagamento(int comcod, int pcocod, DateTime dtpagto)
        {
            try
            {
                if (pcocod <= 0)
                {
                    throw new Exception("O código da parcela deve ser informado!");
                }
                if (comcod <= 0)
                {
                    throw new Exception("O código da compra deve ser informado!");
                }
                if (dtpagto != null)
                {
                    DALParcelasCompra dalObj = new DALParcelasCompra(conexao);

                    dalObj.EfetuarPagamento(comcod, pcocod, dtpagto);
                }
                else
                {
                    throw new Exception("Data de pagamento obrigatoria");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
