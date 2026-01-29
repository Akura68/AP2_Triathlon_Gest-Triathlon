using BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TriathlonDAO
    {
        public static DataTable getlesTriathlons()
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            DataTable dt = new DataTable();
            cmd.Connection = Bdd.getConnexion();
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
            cmd.Connection = Bdd.getConnexion();
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
            cmd.Connection = Bdd.getConnexion();
            cmd.CommandText = "SELECT Triathlon.*,libelleType FROM Triathlon JOIN Type ON Triathlon.codeType = Type.codeType WHERE (lieuT LIKE '" + lieu + "%' AND libelleType LIKE '" + type + "%') AND dateT BETWEEN '" + dateDebut + "' AND '" + dateFin + "'";
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
