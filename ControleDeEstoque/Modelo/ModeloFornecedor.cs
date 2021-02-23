using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Modelo
{
    public class ModeloFornecedor
    {
        #region //Construtores

        public ModeloFornecedor()
        {
            this.ForCod = 0;
            this.ForNome = "";
            this.ForRsocial = "";
            this.ForCnpj = "";
            this.ForIe = "";
            this.ForCep = "";
            this.ForEndereco = "";
            this.ForBairro = "";
            this.ForFone = "";
            this.ForCel = "";
            this.ForEmail = "";
            this.ForEndNumero = 0;
            this.ForCidade = "";
            this.ForEstado = "";
        }


        public ModeloFornecedor(int cod, string nome, string rSocial, string cnpj, string ie, string cep, string endereco, string bairro, string fone, string cel, string email, int endNumero, string cidade, string estado)
        {
            this.ForCod = cod;
            this.ForNome = nome;
            this.ForRsocial = rSocial;
            this.ForCnpj = cnpj;
            this.ForIe = ie;
            this.ForCep = cep;
            this.ForEndereco = endereco;
            this.ForBairro = bairro;
            this.ForFone = fone;
            this.ForCel = cel;
            this.ForEmail = email;
            this.ForEndNumero = endNumero;
            this.ForCidade = cidade;
            this.ForEstado = estado;
        }

        #endregion


        #region //Variaveis
        private int for_cod;
        private string for_nome;
        private string for_rsocial;
        private string for_ie;
        private string for_cnpj;
        private string for_cep;
        private string for_endereco;
        private string for_bairro;
        private string for_fone;
        private string for_cel;
        private string for_email;
        private int for_endnumero;
        private string for_cidade;
        private string for_estado;
        #endregion


        public int ForCod
        {
            get { return for_cod; }
            set { for_cod = value; }
        }
        public string ForNome
        {
            get { return for_nome; }
            set { for_nome = value; }
        }
        public string ForRsocial
        {
            get { return for_rsocial; }
            set { for_rsocial = value; }
        }
        public string ForCnpj
        {
            get { return for_cnpj; }
            set { for_cnpj = value; }
        }
        public string ForIe
        {
            get { return for_ie; }
            set { for_ie = value; }
        }
        public string ForCep
        {
            get { return for_cep; }
            set { for_cep = value; }
        }
        public string ForEndereco
        {
            get { return for_endereco; }
            set { for_endereco = value; }
        }
        public string ForBairro
        {
            get { return for_bairro; }
            set { for_bairro = value; }
        }
        public string ForFone
        {
            get { return for_fone; }
            set { for_fone = value; }
        }
        public string ForCel
        {
            get { return for_cel; }
            set { for_cel = value; }
        }
        public string ForEmail
        {
            get { return for_email; }
            set { for_email = value; }
        }
        public int ForEndNumero
        {
            get { return for_endnumero; }
            set { for_endnumero = value; }
        }
        public string ForCidade
        {
            get { return for_cidade; }
            set { for_cidade = value; }
        }
        public string ForEstado
        {
            get { return for_estado; }
            set { for_estado = value; }
        }
    }
}
