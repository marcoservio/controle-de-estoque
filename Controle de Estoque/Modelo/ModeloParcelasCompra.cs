using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Modelo
{
    public class ModeloParcelasCompra
    {
        #region //Construtores

        public ModeloParcelasCompra()
        {
            this.PcoCod = 0;
            this.PcoValor = 0;
            //this.PcoDataPagto = DateTime.Now;
            this.pco_datavecto = DateTime.Now;
            this.com_cod = 0;
        }


        public ModeloParcelasCompra(int cod, double valor, DateTime dataPagto, DateTime dataVencto, int codCom)
        {
            this.PcoCod = cod;
            this.PcoValor = valor;
            this.PcoDataPagto = dataPagto;
            this.pco_datavecto = dataPagto;
            this.com_cod = codCom;
        }

        #endregion


        #region //Variaveis

        private int pco_cod;
        private int com_cod;
        private double pco_valor;
        private DateTime pco_datapagto;
        private DateTime pco_datavecto;

        #endregion


        public int PcoCod
        {
            get { return pco_cod; }
            set { pco_cod = value; }
        }
        public int ComCod
        {
            get { return com_cod; }
            set { com_cod = value; }
        }
        public double PcoValor
        {
            get { return pco_valor; }
            set { pco_valor = value; }
        }
        public DateTime PcoDataPagto
        {
            get { return pco_datapagto; }
            set { pco_datapagto = value; }
        }
        public DateTime PcoDataVecto
        {
            get { return pco_datavecto; }
            set { pco_datavecto = value; }
        }
    }
}
