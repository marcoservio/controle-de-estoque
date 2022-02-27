using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Modelo
{
    public class ModeloItensCompra
    {
        #region //Construtores

        public ModeloItensCompra()
        {
            this.ItcCod = 0;
            this.ItcQtde = 0;
            this.ItcValor = 0;
            this.ComCod = 0;
            this.ProCod = 0;
        }


        public ModeloItensCompra(int cod, double qtde, double valor, int codCom, int codPro)
        {
            this.ItcCod = cod;
            this.ItcQtde = qtde;
            this.ItcValor = valor;
            this.ComCod = codCom;
            this.ProCod = codPro;
        }

        #endregion


        #region //Variaveis

        private int itc_cod;
        private double itc_qtde;
        private double itc_valor;
        private int com_cod;
        private int pro_cod;

        #endregion


        public int ItcCod
        {
            get { return itc_cod; }
            set { itc_cod = value; }
        }
        public double ItcQtde
        {
            get { return itc_qtde; }
            set { itc_qtde = value; }
        }
        public double ItcValor
        {
            get { return itc_valor; }
            set { itc_valor = value; }
        }
        public int ComCod
        {
            get { return com_cod; }
            set { com_cod = value; }
        }
        public int ProCod
        {
            get { return pro_cod; }
            set { pro_cod = value; }
        }
    }
}
