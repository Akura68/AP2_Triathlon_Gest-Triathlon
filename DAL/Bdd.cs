//using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using Org.BouncyCastle.Pkix;
using System.Data;

namespace DAL
{
    public class Bdd
    {
        private static SqlConnection c;
        // constructeur 
        public Bdd() { }
        // méthode qui initialise une connexion à la base triathlon
        public static bool ouvrirConnexion()
        {
            c = new SqlConnection();
            c.ConnectionString = "Data Source= SRV-SQL\\SQL_SLAM;" + "Initial Catalog=BD_TRIATHLON_GR1;" + "Integrated Security=True;";
            try
            {
                c.Open();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static string afficherConnexion()
        {
            return "Connecté à la base " + c.Database;
        }

        public static SqlConnection getConnexion() { return c; }
    }
}
