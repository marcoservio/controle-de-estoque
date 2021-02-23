using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Modelo
{
    public class ModeloUnidadeDeMedida
    {
        #region //Construtores

        public ModeloUnidadeDeMedida()
        {
            UmedCod = 0;
            UmedNome = "";
        }


        public ModeloUnidadeDeMedida(int cod, string nome)
        {
            UmedCod = cod;
            UmedNome = nome;
        }

        #endregion


        #region //Variaveis

        private int umed_cod;
        private string umed_nome;

        #endregion


        public int UmedCod
        {
            get { return umed_cod; }
            set { umed_cod = value; }
        }
        public string UmedNome
        {
            get { return umed_nome; }
            set { umed_nome = value; }
        }
    }
}
