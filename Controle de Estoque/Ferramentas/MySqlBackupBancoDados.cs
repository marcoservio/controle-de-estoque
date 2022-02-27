using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Ferramentas
{
    public class MySqlBackupBancoDados
    {
        public static ArrayList ObtemBancoDeDadosMySql(string connString)
        {
            ArrayList lista = new ArrayList();

            MySqlConnection cn = new MySqlConnection(connString);

            MySqlCommand cm = new MySqlCommand();

            cm.Connection = cn;
            cm.CommandText = "SHOW TABLES;";

            MySqlDataReader dr;

            try
            {
                cn.Open();
                dr = cm.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(dr["name"]);
                }
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
            finally
            {
                cn.Close();
            }

            return lista;
        }


        public static void BackupDataBase(string connString, string backupFile)
        {
            MySqlConnection cn = new MySqlConnection(connString);

            MySqlCommand cm = new MySqlCommand();
            cm.Connection = cn;

            MySqlBackup mb = new MySqlBackup(cm);

            try
            {
                cn.Open();
                mb.ExportToFile(backupFile);
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
            finally
            {
                cn.Close();
            }
        }


        public static void RestauraDatabase(string connString, string backupFile)
        {
            MySqlConnection.ClearAllPools();

            MySqlConnection cn = new MySqlConnection(connString);

            MySqlCommand cm = new MySqlCommand();
            cm.Connection = cn;

            MySqlBackup mb = new MySqlBackup(cm);

            try
            {
                cn.Open();
                mb.ImportFromFile(backupFile);
            }
            catch (Exception erro)
            {
                throw new Exception(erro.Message);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
