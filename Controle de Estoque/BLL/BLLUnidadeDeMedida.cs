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
    public class BLLUnidadeDeMedida
    {
        #region //Variaveis

        private DALConexao conexao;

        #endregion


        //Construtor
        public BLLUnidadeDeMedida(DALConexao cx)
        {
            this.conexao = cx;
        }


        public void Incluir(ModeloUnidadeDeMedida modelo)
        {
            try
            {
                if (modelo.UmedNome.Trim().Length == 0)
                {
                    throw new Exception("O nome da unidade de medida deve ser informado!");
                }

                DALUnidadeDeMedida dalObj = new DALUnidadeDeMedida(conexao);

                dalObj.Incluir(modelo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public void Alterar(ModeloUnidadeDeMedida modelo)
        {
            try
            {
                if (modelo.UmedCod <= 0)
                {
                    throw new Exception("O código da unidade de medida deve ser informado!");
                }

                if (modelo.UmedNome.Trim().Length == 0)
                {
                    throw new Exception("O nome da unidade de medida deve ser informado!");
                }

                DALUnidadeDeMedida dalObj = new DALUnidadeDeMedida(conexao);

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

                DALUnidadeDeMedida dalObj = new DALUnidadeDeMedida(conexao);

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
                DALUnidadeDeMedida dalObj = new DALUnidadeDeMedida(conexao);

                return dalObj.Localizar(valor);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public ModeloUnidadeDeMedida CarregaModeloUnidadeDeMedida(int codigo)
        {
            try
            {
                if (codigo <= 0)
                {
                    throw new Exception("O código deve ser informado!");
                }

                DALUnidadeDeMedida dalObj = new DALUnidadeDeMedida(conexao);

                return dalObj.CarregaModeloUnidadeDeMedida(codigo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

