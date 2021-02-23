using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using MySql.Data.MySqlClient;
using DAL;
using System.Data;


namespace BLL
{
    public class BLLItensVenda
    {
        #region //Variaveis

        private DALConexao conexao;

        #endregion


        //Construtor
        public BLLItensVenda(DALConexao cx)
        {
            this.conexao = cx;
        }


        public void Incluir(ModeloItensVenda modelo)
        {
            try
            {
                if (modelo.VenCod <= 0)
                {
                    throw new Exception("O código da venda deve ser informado!");
                }
                if (modelo.ItvCod <= 0)
                {
                    throw new Exception("O código do item da venda deve ser informado!");
                }
                if (modelo.ItvQtde <= 0)
                {
                    throw new Exception("A quantidade deve ser maior do que zero!");
                }
                if (modelo.ItvValor <= 0)
                {
                    throw new Exception("O valor do item deve ser maior que zero!");
                }
                if (modelo.ProCod <= 0)
                {
                    throw new Exception("O código do produto deve ser informado!");
                }

                DALItensVenda dalObj = new DALItensVenda(conexao);

                dalObj.Incluir(modelo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public void Alterar(ModeloItensVenda modelo)
        {
            try
            {
                if (modelo.VenCod <= 0)
                {
                    throw new Exception("O código da venda deve ser informado!");
                }
                if (modelo.ItvCod <= 0)
                {
                    throw new Exception("O código do item da venda deve ser informado!");
                }
                if (modelo.ItvQtde <= 0)
                {
                    throw new Exception("A quantidade deve ser maior do que zero!");
                }
                if (modelo.ItvValor <= 0)
                {
                    throw new Exception("O valor do item deve ser maior que zero!");
                }
                if (modelo.ProCod <= 0)
                {
                    throw new Exception("O código do produto deve ser informado!");
                }

                DALItensVenda dalObj = new DALItensVenda(conexao);

                dalObj.Alterar(modelo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public void Excluir(ModeloItensVenda modelo)
        {
            try
            {
                if (modelo.VenCod <= 0)
                {
                    throw new Exception("O código da venda deve ser informado!");
                }
                if (modelo.ItvCod <= 0)
                {
                    throw new Exception("O código do item da venda deve ser informado!");
                }
                if (modelo.ProCod <= 0)
                {
                    throw new Exception("O código do produto deve ser informado!");
                }

                DALItensVenda dalObj = new DALItensVenda(conexao);

                dalObj.Excluir(modelo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public void ExcluirTodosItens(int vencod)
        {
            try
            {
                if (vencod <= 0)
                {
                    throw new Exception("O código da venda deve ser informado!");
                }

                DALItensVenda dalObj = new DALItensVenda(conexao);

                dalObj.ExcluirTodosItens(vencod);
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
                DALItensVenda dalObj = new DALItensVenda(conexao);

                return dalObj.Localizar(vencod);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public ModeloItensVenda CarregaModeloCategoria(int itvcod, int vencod, int procod)
        {
            try
            {
                if (vencod <= 0)
                {
                    throw new Exception("O código da venda deve ser informado!");
                }
                if (itvcod <= 0)
                {
                    throw new Exception("O código do item da venda deve ser informado!");
                }
                if (procod <= 0)
                {
                    throw new Exception("O código do produto deve ser informado!");
                }

                DALItensVenda dalObj = new DALItensVenda(conexao);

                return dalObj.CarregaModeloItensVenda(itvcod, vencod, procod);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
