using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Modelo
{
    public class ModeloProduto
    {
        #region //Construtores

        public ModeloProduto()
        {
            this.Pro_Cod = 0;
            this.Pro_Nome = "";
            this.Pro_Descricao = "";
            this.Pro_ValorPago = 0;
            this.Pro_ValorVenda = 0;
            this.Pro_Qtde = 0;
            this.Umed_Cod = 0;
            this.Cat_Cod = 0;
            this.Scat_Cod = 0;
        }


        public ModeloProduto(int cod, string nome, string descricao, double valorPago, double valorVenda, double qtde, int codUmed, int codCat, int codScat)
        {
            this.Pro_Cod = cod;
            this.Pro_Nome = nome;
            this.Pro_Descricao = descricao;
            this.Pro_ValorPago = valorPago;
            this.Pro_ValorVenda = valorVenda;
            this.Pro_Qtde = qtde;
            this.Umed_Cod = codUmed;
            this.Cat_Cod = codCat;
            this.Scat_Cod = codScat;
        }

        #endregion


        #region //Variaveis

        private int pro_cod;
        private string pro_nome;
        private string pro_descricao;
        private double pro_valorpago;
        private double pro_valorvenda;
        private double pro_qtde;
        private int umed_cod;
        private int cat_cod;
        private int scat_cod;

        #endregion


        public int Pro_Cod
        {
            get { return pro_cod; }
            set { pro_cod = value; }
        }
        public string Pro_Nome
        {
            get { return pro_nome; }
            set { pro_nome = value; }
        }
        public string Pro_Descricao
        {
            get { return pro_descricao; }
            set { pro_descricao = value; }
        }
        public double Pro_ValorPago
        {
            get { return pro_valorpago; }
            set { pro_valorpago = value; }
        }
        public double Pro_ValorVenda
        {
            get { return pro_valorvenda; }
            set { pro_valorvenda = value; }
        }
        public double Pro_Qtde
        {
            get { return pro_qtde; }
            set { pro_qtde = value; }
        }
        public int Umed_Cod
        {
            get { return umed_cod; }
            set { umed_cod = value; }
        }
        public int Cat_Cod
        {
            get { return cat_cod; }
            set { cat_cod = value; }
        }
        public int Scat_Cod
        {
            get { return scat_cod; }
            set { scat_cod = value; }
        }
    }
}
