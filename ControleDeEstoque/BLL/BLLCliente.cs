using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using DAL;
using System.Data;
using Ferramentas;


namespace BLL
{
    public class BLLCliente
    {
        #region //Variaveis

        private DALConexao conexao;

        #endregion


        //Construtor
        public BLLCliente(DALConexao cx)
        {
            this.conexao = cx;
        }


        public void Incluir(ModeloCliente modelo)
        {
            //cli_tipo = 0 -> Pessoa Fisica
            //cli_tipo = 1 -> Pessoa Juridica

            try
            {
                if (modelo.CliNome.Trim().Length == 0)
                {
                    throw new Exception("O nome do cliente deve ser informado!");
                }
                if (modelo.CliCpfCnpj.Trim().Length == 0)
                {
                    throw new Exception("O CPF/CNPJ do cliente deve ser informado!");
                }
                if (modelo.CliTipo == 0)
                {
                    if (Validacao.IsCpf(modelo.CliCpfCnpj) == false)
                    {
                        throw new Exception("CPF inválido!");
                    }
                }
                else
                {
                    if (Validacao.IsCnpj(modelo.CliCpfCnpj) == false)
                    {
                        throw new Exception("CNPJ inválido!");
                    }
                }
                if (modelo.CliRgIe.Trim().Length == 0)
                {
                    throw new Exception("O RG/IE do cliente deve ser informado!");
                }
                if (modelo.CliFone.Trim().Length == 0)
                {
                    throw new Exception("O telefone do cliente deve ser informado!");
                }
                if (Validacao.ValidaEmail(modelo.CliEmail) == false)
                {
                    throw new Exception("E-mail inválido!");
                }
                if (Validacao.ValidaCep(modelo.CliCep) == false)
                {
                    throw new Exception("CEP inválido!");
                }

                DALCliente dalObj = new DALCliente(conexao);

                dalObj.Incluir(modelo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public void Alterar(ModeloCliente modelo)
        {
            //cli_tipo = 0 -> Pessoa Fisica
            //cli_tipo = 1 -> Pessoa Juridica
            try
            {
                if (modelo.CliNome.Trim().Length == 0)
                {
                    throw new Exception("O nome do cliente deve ser informado!");
                }
                if (modelo.CliCpfCnpj.Trim().Length == 0)
                {
                    throw new Exception("O CPF/CNPJ do cliente deve ser informado!");
                }
                if (modelo.CliTipo == 0)
                {
                    if (Validacao.IsCpf(modelo.CliCpfCnpj) == false)
                    {
                        throw new Exception("CPF inválido!");
                    }
                }
                else
                {
                    if (Validacao.IsCnpj(modelo.CliCpfCnpj) == false)
                    {
                        throw new Exception("CNPJ inválido!");
                    }
                }
                if (modelo.CliRgIe.Trim().Length == 0)
                {
                    throw new Exception("O RG/IE do cliente deve ser informado!");
                }
                if (modelo.CliFone.Trim().Length == 0)
                {
                    throw new Exception("O telefone do cliente deve ser informado!");
                }
                if (Validacao.ValidaEmail(modelo.CliEmail) == false)
                {
                    throw new Exception("E-mail inválido!");
                }
                if (Validacao.ValidaCep(modelo.CliCep) == false)
                {
                    throw new Exception("CEP inválido!");
                }

                DALCliente dalObj = new DALCliente(conexao);

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

                DALCliente dalObj = new DALCliente(conexao);

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
                DALCliente dalObj = new DALCliente(conexao);

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
                DALCliente dalObj = new DALCliente(conexao);

                return dalObj.LocalizarNome(valor);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public DataTable LocalizarCPFCNPJ(string valor)
        {
            try
            {
                DALCliente dalObj = new DALCliente(conexao);

                return dalObj.LocalizarCPFCNPJ(valor);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public ModeloCliente CarregaModeloCliente(int codigo)
        {
            try
            {
                if (codigo <= 0)
                {
                    throw new Exception("O código deve ser informado!");
                }

                DALCliente dalObj = new DALCliente(conexao);

                return dalObj.CarregaModeloCliente(codigo);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public ModeloCliente CarregaModeloCliente(string cpfcnpj)
        {
            try
            {
                if (cpfcnpj.Trim().Length == 0)
                {
                    throw new Exception("O CPF/CNPJ deve ser informado!");
                }

                DALCliente dalObj = new DALCliente(conexao);

                return dalObj.CarregaModeloCliente(cpfcnpj);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
