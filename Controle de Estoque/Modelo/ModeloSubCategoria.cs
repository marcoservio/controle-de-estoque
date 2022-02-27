using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Modelo
{
    public class ModeloSubCategoria
    {
        #region //Construtores

        public ModeloSubCategoria()
        {
            this.ScatCod = 0;
            this.ScatNome = "";
            this.CatCod = 0;
        }


        public ModeloSubCategoria(int cod, string nome, int codCat)
        {
            this.ScatCod = cod;
            this.ScatNome = nome;
            this.CatCod = codCat;
        }

        #endregion


        #region //Variaveis

        private int scat_cod;
        private string scat_nome;
        private int cat_cod;

        #endregion


        public int ScatCod
        {
            get { return scat_cod; }
            set { scat_cod = value; }
        }
        public string ScatNome
        {
            get { return scat_nome; }
            set { scat_nome = value; }
        }
        public int CatCod
        {
            get { return cat_cod; }
            set { cat_cod = value; }
        }
    }
}
