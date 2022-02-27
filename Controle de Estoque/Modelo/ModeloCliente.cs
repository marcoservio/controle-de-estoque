using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Modelo
{
    public class ModeloCliente
    {
        #region //Construtores

        public ModeloCliente()
        {
            this.CliCod = 0;
            this.CliNome = "";
            this.CliCpfCnpj = "";
            this.CliRgIe = "";
            this.CliRsocial = "";
            this.CliTipo = 0;
            this.CliCep = "";
            this.CliEndereco = "";
            this.CliBairro = "";
            this.CliFone = "";
            this.CliCel = "";
            this.CliEmail = "";
            this.CliEndNumero = 0;
            this.CliCidade = "";
            this.CliEstado = "";
        }


        public ModeloCliente(int cod, string nome, string cpfCnpj, string rgIe, string rSocial, int tipo, string cep, string endereco, string bairro, string fone, string cel, string email, int endNumero, string cidade, string estado)
        {
            this.CliCod = cod;
            this.CliNome = nome;
            this.CliCpfCnpj = cpfCnpj;
            this.CliRgIe = rgIe;
            this.CliRsocial = rSocial;
            this.CliTipo = tipo;
            this.CliCep = cep;
            this.CliEndereco = endereco;
            this.CliBairro = bairro;
            this.CliFone = fone;
            this.CliCel = cel;
            this.CliEmail = email;
            this.CliEndNumero = endNumero;
            this.CliCidade = cidade;
            this.CliEstado = estado;
        }

        #endregion


        #region //Variaveis

        private int cli_cod;
        private string cli_nome;
        private string cli_cpfcnpj;
        private string cli_rgie;
        private string cli_rsocial;
        private int cli_tipo;
        private string cli_cep;
        private string cli_endereco;
        private string cli_bairro;
        private string cli_fone;
        private string cli_cel;
        private string cli_email;
        private int cli_endnumero;
        private string cli_cidade;
        private string cli_estado;

        #endregion


        public int CliCod
        {
            get { return cli_cod; }
            set { cli_cod = value; }
        }
        public string CliNome
        {
            get { return cli_nome; }
            set { cli_nome = value; }
        }
        public string CliCpfCnpj
        {
            get { return cli_cpfcnpj; }
            set { cli_cpfcnpj = value; }
        }
        public string CliRgIe
        {
            get { return cli_rgie; }
            set { cli_rgie = value; }
        }
        public string CliRsocial
        {
            get { return cli_rsocial; }
            set { cli_rsocial = value; }
        }
        public int CliTipo
        {
            get { return cli_tipo; }
            set { cli_tipo = value; }
        }
        public string CliCep
        {
            get { return cli_cep; }
            set { cli_cep = value; }
        }
        public string CliEndereco
        {
            get { return cli_endereco; }
            set { cli_endereco = value; }
        }
        public string CliBairro
        {
            get { return cli_bairro; }
            set { cli_bairro = value; }
        }
        public string CliFone
        {
            get { return cli_fone; }
            set { cli_fone = value; }
        }
        public string CliCel
        {
            get { return cli_cel; }
            set { cli_cel = value; }
        }
        public string CliEmail
        {
            get { return cli_email; }
            set { cli_email = value; }
        }
        public int CliEndNumero
        {
            get { return cli_endnumero; }
            set { cli_endnumero = value; }
        }
        public string CliCidade
        {
            get { return cli_cidade; }
            set { cli_cidade = value; }
        }
        public string CliEstado
        {
            get { return cli_estado; }
            set { cli_estado = value; }
        }
    }
}
