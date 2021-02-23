using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Modelo
{
    public class ModeloVenda
    {
        #region //Construtores

        public ModeloVenda()
        {
            this.VenCod = 0;
            this.VenData = DateTime.Now;
            this.VenNfiscal = 0;
            this.VenTotal = 0;
            this.VenNparcelas = 0;
            this.VenStatus = 0; //0 = Ativa | 1 = Cancelada
            this.CliCod = 0;
            this.TpaCod = 0;
            this.VenAvista = 0; //0 = Avista | 1 = Não é avista
        }


        public ModeloVenda(int cod, DateTime data, int nFiscal, double total, int nParcelas, int status, int codCli, int codTpa, int avista)
        {
            this.VenCod = cod;
            this.VenData = data;
            this.VenNfiscal = nFiscal;
            this.VenTotal = total;
            this.VenNparcelas = nParcelas;
            this.VenStatus = status;
            this.CliCod = codCli;
            this.TpaCod = codTpa;
            this.VenAvista = avista;
        }

        #endregion


        #region //Variaveis

        private int ven_cod;
        private DateTime ven_data;
        private int ven_nfiscal;
        private double ven_total;
        private int ven_nparcelas;
        private int ven_status;
        private int cli_cod;
        private int tpa_cod;
        private int ven_avista;

        #endregion


        public int VenCod
        {
            get { return ven_cod; }
            set { ven_cod = value; }
        }
        public DateTime VenData
        {
            get { return ven_data; }
            set { ven_data = value; }
        }
        public int VenNfiscal
        {
            get { return ven_nfiscal; }
            set { ven_nfiscal = value; }
        }
        public double VenTotal
        {
            get { return ven_total; }
            set { ven_total = value; }
        }
        public int VenNparcelas
        {
            get { return ven_nparcelas; }
            set { ven_nparcelas = value; }
        }
        public int VenStatus
        {
            get { return ven_status; }
            set { ven_status = value; }
        }
        public int CliCod
        {
            get { return cli_cod; }
            set { cli_cod = value; }
        }
        public int TpaCod
        {
            get { return tpa_cod; }
            set { tpa_cod = value; }
        }
        public int VenAvista
        {
            get { return ven_avista; }
            set { ven_avista = value; }
        }
    }
}
