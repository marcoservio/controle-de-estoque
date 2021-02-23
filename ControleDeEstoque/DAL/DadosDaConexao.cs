using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class DadosDaConexao
    {
        public static string servidor = "127.0.0.1";
        public static string banco = "controle_de_estoque";
        public static string usuario = "root";
        public static string senha = "";


        public static string StringDeConexao
        {
            get { return "SERVER=" + servidor + ";DATABASE=" + banco + ";UID=" + usuario + ";PASSWORD=" + senha + ";"; }
        }
    }
}
