using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Modelo;
using System.Data;


namespace BLL
{
    public class BLLProduto
    {
        #region //Variaveis

        private DALConexao conexao;

        #endregion


        //Construtor
        public BLLProduto(DALConexao cx)
        {
            this.conexao = cx;
        }


        public void Incluir(ModeloProduto modelo)
        {
            try
            {
                if (modelo.Pro_Nome.Trim().Length == 0)
                {
                    throw new Exception("O nome do produto deve ser informado!");
                }
                if (modelo.Pro_Descricao.Trim().Length == 0)
                {
                    throw new Exception("A descrição do Produto deve ser informada!");
                }
                if (modelo.Pro_ValorVenda <= 0)
                {
                    throw new Exception("O valor de venda do produto deve ser informado!");
                }
                if (modelo.Pro_Qtde <= 0)
                {
                    throw new Exception("A quantidade do produto deve ser maior ou igual a zero!");
                }
                if (modelo.Cat_Cod <= 0)
                {
                    throw new Exception("O código da categoria deve ser informado!");
                }
                if (modelo.Umed_Cod <= 0)
                {
                    throw new Exception("O código da unidade de medida deve ser informado!");
                }
                if (modelo.Scat_Cod <= 0)
                {
                    throw new Exception("O codigo da subcategoria categoria deve ser informado!");
                }

                DALProduto dalObj = new DALProduto(conexao);

                dalObj.Incluir(modelo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public void Alterar(ModeloProduto modelo)
        {
            try
            {
                if (modelo.Pro_Cod <= 0)
                {
                    throw new Exception("O código do produto deve ser informado!");
                }
                if (modelo.Pro_Nome.Trim().Length == 0)
                {
                    throw new Exception("O nome do produto deve ser informada!");
                }
                if (modelo.Pro_Descricao.Trim().Length == 0)
                {
                    throw new Exception("A descrição do Produto deve ser informado!");
                }
                if (modelo.Pro_ValorVenda <= 0)
                {
                    throw new Exception("O valor de venda do produto deve ser informado!");
                }
                if (modelo.Pro_Qtde <= 0)
                {
                    throw new Exception("A quantidade do produto deve ser maior ou igual a zero!");
                }
                if (modelo.Cat_Cod <= 0)
                {
                    throw new Exception("O código da categoria deve ser informado!");
                }
                if (modelo.Umed_Cod <= 0)
                {
                    throw new Exception("O código da unidade de medida deve ser informado!");
                }
                if (modelo.Scat_Cod <= 0)
                {
                    throw new Exception("O codigo da subcategoria categoria deve ser informado!");
                }

                DALProduto dalObj = new DALProduto(conexao);

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

                DALProduto dalObj = new DALProduto(conexao);

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
                DALProduto dalObj = new DALProduto(conexao);

                return dalObj.Localizar(valor);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public ModeloProduto CarregaModeloProduto(int codigo)
        {
            try
            {
                if (codigo <= 0)
                {
                    throw new Exception("O código deve ser informado!");
                }

                DALProduto dalObj = new DALProduto(conexao);

                return dalObj.CarregaModeloProduto(codigo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
