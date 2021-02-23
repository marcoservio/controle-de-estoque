using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Modelo
{
    public class ModeloCompra
    {
        #region //Construtores

        public ModeloCompra()
        {
            this.ComCod = 0;
            this.ComData = DateTime.Now;
            this.ComNfiscal = 0;
            this.ComTotal = 0;
            this.ComNparcelas = 0;
            this.ComStatus = 0; //0 = Ativa | 1 = Cancelada
            this.ForCod = 0;
            this.TpaCod = 0;
        }


        public ModeloCompra(int cod, DateTime data, int nFiscal, double total, int nParcelas, int status, int codFor, int codTpa)
        {
            this.ComCod = cod;
            this.ComData = data;
            this.ComNfiscal = nFiscal;
            this.ComTotal = total;
            this.ComNparcelas = nParcelas;
            this.ComStatus = status;
            this.ForCod = codFor;
            this.TpaCod = codTpa;
        }

        #endregion


        #region //Variaveis

        private int com_cod;
        private DateTime com_data;
        private int com_nfiscal;
        private double com_total;
        private int com_nparcelas;
        private int com_status;
        private int for_cod;
        private int tpa_cod;

        #endregion


        public int ComCod
        {
            get { return com_cod; }
            set { com_cod = value; }
        }
        public DateTime ComData
        {
            get { return com_data; }
            set { com_data = value; }
        }
        public int ComNfiscal
        {
            get { return com_nfiscal; }
            set { com_nfiscal = value; }
        }
        public double ComTotal
        {
            get { return com_total; }
            set { com_total = value; }
        }
        public int ComNparcelas
        {
            get { return com_nparcelas; }
            set { com_nparcelas = value; }
        }
        public int ComStatus
        {
            get { return com_status; }
            set { com_status = value; }
        }
        public int ForCod
        {
            get { return for_cod; }
            set { for_cod = value; }
        }
        public int TpaCod
        {
            get { return tpa_cod; }
            set { tpa_cod = value; }
        }
    }
}
