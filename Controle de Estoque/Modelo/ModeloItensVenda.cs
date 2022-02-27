using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Modelo
{
    public class ModeloItensVenda
    {
        #region //Construtores

        public ModeloItensVenda()
        {
            this.ItvCod = 0;
            this.ItvQtde = 0;
            this.ItvValor = 0;
            this.VenCod = 0;
            this.ProCod = 0;
        }


        public ModeloItensVenda(int cod, double qtde, double valor, int codVen, int codPro)
        {
            this.ItvCod = cod;
            this.ItvQtde = qtde;
            this.ItvValor = valor;
            this.VenCod = codVen;
            this.ProCod = codPro;
        }

        #endregion


        #region //Variaveis

        private int itv_cod;
        private double itv_qtde;
        private double itv_valor;
        private int ven_cod;
        private int pro_cod;

        #endregion


        public int ItvCod
        {
            get { return itv_cod; }
            set { itv_cod = value; }
        }
        public double ItvQtde
        {
            get { return itv_qtde; }
            set { itv_qtde = value; }
        }
        public double ItvValor
        {
            get { return itv_valor; }
            set { itv_valor = value; }
        }
        public int VenCod
        {
            get { return ven_cod; }
            set { ven_cod = value; }
        }
        public int ProCod
        {
            get { return pro_cod; }
            set { pro_cod = value; }
        }
    }
}
