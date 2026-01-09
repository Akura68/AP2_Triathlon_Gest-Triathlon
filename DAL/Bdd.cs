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

        public static DataTable getlesTriathlons()
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            DataTable dt = new DataTable();
            cmd.Connection = c;
            cmd.CommandText = "SELECT Triathlon.*,libelleType FROM Triathlon JOIN type ON Triathlon.codeType = Type.codeType";
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

        public static List<Triathlon> getFiltreTriathlons()
        {
            List<Triathlon> res = new List<Triathlon>();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            cmd.Connection = c;
            cmd.CommandText = "SELECT Triathlon.*,libelleType FROM Triathlon JOIN Type ON Triathlon.codeType = Type.codeType";
            try
            {
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Triathlon t = new Triathlon(dr.GetInt32(0), dr.GetString(1), dr.GetDateTime(2), dr.GetString(3), dr.GetInt32(4), dr.GetString(5));
                    res.Add(t);
                }

                dr.Close();
                return res;
            }
            catch 
            { 
                return null;
            }
        }

        public static DataTable getTriathlonsFiltrer(string lieu, string type, string dateDebut, string dateFin)
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            DataTable dt = new DataTable();
            cmd.Connection = c;
            cmd.CommandText = "SELECT Triathlon.*,libelleType FROM Triathlon JOIN Type ON Triathlon.codeType = Type.codeType WHERE lieuT LIKE '" + lieu + "%' OR libelleType LIKE '" + type + "%' AND dateT BETWEEN '" + dateDebut + "' AND '" + dateFin + "'";
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
