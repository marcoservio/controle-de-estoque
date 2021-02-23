using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Modelo
{
    public class ModeloTipoPagamento
    {
        #region //Construtores

        public ModeloTipoPagamento()
        {
            this.TpaCod = 0;
            this.TpaNome = "";
        }


        public ModeloTipoPagamento(int cod, string nome)
        {
            this.TpaCod = cod;
            this.TpaNome = nome;
        }

        #endregion


        #region //Variaveis

        private int tpa_cod;
        private string tpa_nome;

        #endregion


        public int TpaCod
        {
            get { return tpa_cod; }
            set { tpa_cod = value; }
        }
        public string TpaNome
        {
            get { return tpa_nome; }
            set { tpa_nome = value; }
        }
    }
}
