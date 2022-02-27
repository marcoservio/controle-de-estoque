using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ferramentas
{
    public class BuscaEndereco
    {
        static public string cep = "";
        static public string cidade = "";
        static public string estado = "";
        static public string endereco = "";
        static public string bairro = "";


        public static bool VerificaCEP(string CEP)
        {
            bool flag = false;

            try
            {
                DataSet ds = new DataSet();
                string xml = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml".Replace("@cep", CEP);
                ds.ReadXml(xml);

                endereco = ds.Tables[0].Rows[0]["logradouro"].ToString();
                bairro = ds.Tables[0].Rows[0]["bairro"].ToString();
                cidade = ds.Tables[0].Rows[0]["cidade"].ToString();
                estado = ds.Tables[0].Rows[0]["uf"].ToString();
                cep = CEP;

                flag = true;
            }
            catch (Exception)
            {
                endereco = "";
                bairro = "";
                cidade = "";
                estado = "";
                cep = "";
            }

            return flag;
        }
    }
}
