using MySql.Data.MySqlClient;
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
        private static MySqlConnection c;
        // constructeur 
        public Bdd() { }
        // méthode qui initialise une connexion à la base autoecole
        public static bool ouvrirConnexion()
        {
            c = new MySqlConnection();
            c.ConnectionString = "server=localhost;user id=root;database=gesttest";
            // on peut aussi définir des variables host, user, password et bd
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

        public static DataTable getlesTriathlons()
        {
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader dr;
            DataTable dt = new DataTable();
            cmd.Connection = c;
            cmd.CommandText = "SELECT * FROM triathlon";
            try
            {
                dr = cmd.ExecuteReader();
                dt.Load(dr);
                dr.Close();
                return dt;
            }
            catch
            {
                return null;
            }
        }
    }
}
