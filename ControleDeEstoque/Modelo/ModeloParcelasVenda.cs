using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Modelo
{
    public class ModeloParcelasVenda
    {
        #region //Construtores

        public ModeloParcelasVenda()
        {
            this.PveCod = 0;
            this.PveValor = 0;
            this.PveDataPagto = DateTime.Now;
            this.PveDataVecto = DateTime.Now;
            this.VenCod = 0;
        }


        public ModeloParcelasVenda(int cod, double valor, DateTime dataPagto, DateTime dataVecto, int codCom)
        {
            this.PveCod = cod;
            this.PveValor = valor;
            this.PveDataPagto = dataPagto;
            this.PveDataVecto = dataVecto;
            this.VenCod = codCom;
        }

        #endregion


        #region //Variaveis

        private int pve_cod;
        private int ven_cod;
        private double pve_valor;
        private DateTime pve_datapagto;
        private DateTime pve_datavecto;

        #endregion


        public int PveCod
        {
            get { return pve_cod; }
            set { pve_cod = value; }
        }
        public int VenCod
        {
            get { return ven_cod; }
            set { ven_cod = value; }
        }
        public double PveValor
        {
            get { return pve_valor; }
            set { pve_valor = value; }
        }
        public DateTime PveDataPagto
        {
            get { return pve_datapagto; }
            set { pve_datapagto = value; }
        }
        public DateTime PveDataVecto
        {
            get { return pve_datavecto; }
            set { pve_datavecto = value; }
        }
    }
}
