using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Modelo
{
    public class ModeloCategoria
    {
        #region //Construtores

        public ModeloCategoria()
        {
            this.CatCod = 0;
            this.CatNome = "";
        }


        public ModeloCategoria(int cod, string nome)
        {
            this.CatCod = cod;
            this.CatNome = nome;
        }

        #endregion


        #region //Variaveis

        private int cat_cod;
        private string cat_nome;

        #endregion


        public int CatCod
        {
            get { return cat_cod; }
            set { cat_cod = value; }
        }
        public string CatNome
        {
            get { return cat_nome; }
            set { cat_nome = value; }
        }
    }
}
