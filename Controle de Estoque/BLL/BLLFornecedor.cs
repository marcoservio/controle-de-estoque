using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data;
using DAL;
using Ferramentas;


namespace BLL
{
    public class BLLFornecedor
    {
        #region //Variaveis

        private DALConexao conexao;

        #endregion


        //Construtor
        public BLLFornecedor(DALConexao cx)
        {
            this.conexao = cx;
        }


        public void Incluir(ModeloFornecedor modelo)
        {
            try
            {
                if (modelo.ForNome.Trim().Length == 0)
                {
                    throw new Exception("O nome do cliente deve ser informado!");
                }
                if (modelo.ForCnpj.Trim().Length == 0)
                {
                    throw new Exception("O CPF/CNPJ do cliente deve ser informado!");
                }
                if (Validacao.IsCnpj(modelo.ForCnpj) == false)
                {
                    throw new Exception("CNPJ inválido");
                }
                if (modelo.ForIe.Trim().Length == 0)
                {
                    throw new Exception("O RG/IE do cliente deve ser informado!");
                }
                if (modelo.ForFone.Trim().Length == 0)
                {
                    throw new Exception("O telefone do cliente deve ser informado!");
                }
                if (Validacao.ValidaEmail(modelo.ForEmail) == false)
                {
                    throw new Exception("E-mail inválido!");
                }
                if (Validacao.ValidaCep(modelo.ForCep) == false)
                {
                    throw new Exception("CEP inválido!");
                }

                DALFornecedor dalObj = new DALFornecedor(conexao);

                dalObj.Incluir(modelo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public void Alterar(ModeloFornecedor modelo)
        {
            try
            {
                if (modelo.ForNome.Trim().Length == 0)
                {
                    throw new Exception("O nome do cliente deve ser informado!");
                }
                if (modelo.ForCnpj.Trim().Length == 0)
                {
                    throw new Exception("O CPF/CNPJ do cliente deve ser informado!");
                }
                if (Validacao.IsCnpj(modelo.ForCnpj) == false)
                {
                    throw new Exception("CNPJ inválido!");
                }
                if (modelo.ForIe.Trim().Length == 0)
                {
                    throw new Exception("O RG/IE do cliente deve ser informado!");
                }
                if (modelo.ForFone.Trim().Length == 0)
                {
                    throw new Exception("O telefone do cliente deve ser informado!");
                }
                if (Validacao.ValidaEmail(modelo.ForEmail) == false)
                {
                    throw new Exception("E-mail inválido!");
                }
                if (Validacao.ValidaCep(modelo.ForCep) == false)
                {
                    throw new Exception("CEP inválido!");
                }

                DALFornecedor dalObj = new DALFornecedor(conexao);

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

                DALFornecedor dalObj = new DALFornecedor(conexao);

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
                DALFornecedor dalObj = new DALFornecedor(conexao);

                return dalObj.Localizar(valor);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public DataTable LocalizarNome(string valor)
        {
            try
            {
                DALFornecedor dalObj = new DALFornecedor(conexao);

                return dalObj.LocalizarNome(valor);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public DataTable LocalizarCNPJ(string valor)
        {
            try
            {
                DALFornecedor dalObj = new DALFornecedor(conexao);

                return dalObj.LocalizarCNPJ(valor);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public ModeloFornecedor CarregaModeloFornecedor(int codigo)
        {
            try
            {
                if (codigo <= 0)
                {
                    throw new Exception("O código deve ser informado!");
                }

                DALFornecedor dalObj = new DALFornecedor(conexao);

                return dalObj.CarregaModeloFornecedor(codigo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public ModeloFornecedor CarregaModeloFornecedor(string cnpj)
        {
            try
            {
                if (cnpj.Trim().Length == 0)
                {
                    throw new Exception("O cnpj deve ser informado!");
                }

                DALFornecedor dalObj = new DALFornecedor(conexao);

                return dalObj.CarregaModeloFornecedor(cnpj);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
