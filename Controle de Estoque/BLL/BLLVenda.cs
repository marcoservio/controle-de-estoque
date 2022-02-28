using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using Modelo;


namespace BLL
{
    public class BLLVenda
    {
        #region //Variaveis

        private DALConexao conexao;

        #endregion


        //Construtor
        public BLLVenda(DALConexao cx)
        {
            this.conexao = cx;
        }


        public void Incluir(ModeloVenda modelo)
        {
            try
            {
                if (modelo.VenNparcelas <= 0)
                {
                    throw new Exception("O número de parcelas deve ser maior do que zero!");
                }
                if (modelo.CliCod <= 0)
                {
                    throw new Exception("O código do cliente deve ser informado!");
                }
                if (modelo.VenTotal <= 0)
                {
                    throw new Exception("O valor da venda deve ser informado!");
                }
                if (modelo.VenNfiscal <= 0)
                {
                    throw new Exception("O número da nota fiscal deve ser informado!");
                }

                DALVenda dalObj = new DALVenda(conexao);

                dalObj.Incluir(modelo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public void Alterar(ModeloVenda modelo)
        {
            try
            {
                if (modelo.VenNparcelas <= 0)
                {
                    throw new Exception("O número de parcelas deve ser maior do que zero!");
                }
                if (modelo.CliCod <= 0)
                {
                    throw new Exception("O código do cliente deve ser informado!");
                }
                if (modelo.VenTotal <= 0)
                {
                    throw new Exception("O valor da venda deve ser informado!");
                }
                if (modelo.VenNfiscal <= 0)
                {
                    throw new Exception("O número da nota fiscal deve ser informado!");
                }

                DALVenda dalObj = new DALVenda(conexao);

                dalObj.Alterar(modelo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public bool CancelarVenda(int codigo)
        {
            try
            {
                if (codigo <= 0)
                {
                    throw new Exception("O código deve ser informado!");
                }

                DALVenda dalObj = new DALVenda(conexao);

                return dalObj.CancelarVenda(codigo);
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

                DALVenda dalObj = new DALVenda(conexao);

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
                DALVenda dalObj = new DALVenda(conexao);

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
                DALVenda dalObj = new DALVenda(conexao);

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
                DALVenda dalObj = new DALVenda(conexao);

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
                DALVenda dalObj = new DALVenda(conexao);

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
                DALVenda dalObj = new DALVenda(conexao);

                return dalObj.LocalizarParcelasEmAberto();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public int QuantidadeParcelasNãoPagas(int comcod)
        {
            try
            {
                if (comcod <= 0)
                {
                    throw new Exception("O código deve ser informado!");
                }

                DALVenda dalObj = new DALVenda(conexao);

                return dalObj.QuantidadeParcelasNãoPagas(comcod);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public ModeloVenda CarregaModeloVenda(int codigo)
        {
            try
            {
                if (codigo <= 0)
                {
                    throw new Exception("O código deve ser informado!");
                }

                DALVenda dalObj = new DALVenda(conexao);

                return dalObj.CarregaModeloVenda(codigo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
