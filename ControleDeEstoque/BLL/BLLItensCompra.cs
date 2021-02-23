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
    public class BLLItensCompra
    {
        #region //Variaveis

        private DALConexao conexao;

        #endregion


        //Construtor
        public BLLItensCompra(DALConexao cx)
        {
            this.conexao = cx;
        }


        public void Incluir(ModeloItensCompra modelo)
        {
            try
            {
                if (modelo.ComCod <= 0)
                {
                    throw new Exception("O código da compra deve ser informado!");
                }
                if (modelo.ItcCod <= 0)
                {
                    throw new Exception("O código do item da compra deve ser informado!");
                }
                if (modelo.ItcQtde <= 0)
                {
                    throw new Exception("A quantidade deve ser maior do que zero!");
                }
                if (modelo.ItcValor <= 0)
                {
                    throw new Exception("O valor do item deve ser maior que zero!");
                }
                if (modelo.ProCod <= 0)
                {
                    throw new Exception("O código do produto deve ser informado!");
                }

                DALItensCompra dalObj = new DALItensCompra(conexao);

                dalObj.Incluir(modelo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public void Alterar(ModeloItensCompra modelo)
        {
            try
            {
                if (modelo.ComCod <= 0)
                {
                    throw new Exception("O código da compra deve ser informado!");
                }
                if (modelo.ItcCod <= 0)
                {
                    throw new Exception("O código do item da compra deve ser informado!");
                }
                if (modelo.ItcQtde <= 0)
                {
                    throw new Exception("A quantidade deve ser maior do que zero!");
                }
                if (modelo.ItcValor <= 0)
                {
                    throw new Exception("O valor do item deve ser maior que zero!");
                }
                if (modelo.ProCod <= 0)
                {
                    throw new Exception("O código do produto deve ser informado!");
                }

                DALItensCompra dalObj = new DALItensCompra(conexao);

                dalObj.Alterar(modelo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public void Excluir(ModeloItensCompra modelo)
        {
            try
            {
                if (modelo.ComCod <= 0)
                {
                    throw new Exception("O código da compra deve ser informado!");
                }
                if (modelo.ItcCod <= 0)
                {
                    throw new Exception("O código do item da compra deve ser informado!");
                }
                if (modelo.ProCod <= 0)
                {
                    throw new Exception("O código do produto deve ser informado!");
                }

                DALItensCompra dalObj = new DALItensCompra(conexao);

                dalObj.Excluir(modelo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public void ExcluirTodosItens(int comcod)
        {
            try
            {
                if (comcod <= 0)
                {
                    throw new Exception("O código da compra deve ser informado!");
                }

                DALItensCompra dalObj = new DALItensCompra(conexao);

                dalObj.ExcluirTodosItens(comcod);
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
                DALItensCompra dalObj = new DALItensCompra(conexao);

                return dalObj.Localizar(comcod);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public ModeloItensCompra CarregaModeloCategoria(int itccod, int comcod, int procod)
        {
            try
            {
                if (comcod <= 0)
                {
                    throw new Exception("O código da compra deve ser informado!");
                }
                if (itccod <= 0)
                {
                    throw new Exception("O código do item da compra deve ser informado!");
                }
                if (procod <= 0)
                {
                    throw new Exception("O código do produto deve ser informado!");
                }

                DALItensCompra dalObj = new DALItensCompra(conexao);

                return dalObj.CarregaModeloItensCompra(itccod, comcod, procod);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
