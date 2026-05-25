using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CatégoriesDAO
    {
        public static DataTable getLesCategories()
        {
            SqlCommand cmd = new SqlCommand();
            SqlDataReader dr;
            DataTable dt = new DataTable();
            cmd.Connection = Bdd.getConnexion();
            cmd.CommandText = "SELECT * FROM Categorie";
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

        public static string ajouterCategorie(string libelle, string ageMin, string ageMax)
        {
            object res;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Bdd.getConnexion();
            cmd.CommandText = "INSERT INTO Categorie(code, libelle, agemini, agemaxi) VALUES('" + getMaxCode() + "', '" + libelle + "', '" + ageMin + "', '" + ageMax + "')";
            try
            {
                res = cmd.ExecuteScalar();
                return Convert.ToString(res);
            }
            catch
            {
                return null;
            }
        }

        public static string modifierCategorie(int code, string libelle, string ageMin, string ageMax)
        {
            object res;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Bdd.getConnexion();
            cmd.CommandText = "UPDATE Categorie SET libelle='" + libelle + "', agemini='" + ageMin + "', agemaxi='" + ageMax + "' WHERE code='" + code + "'";
            try
            {
                res = cmd.ExecuteScalar();
                return Convert.ToString(res);
            }
            catch
            {
                return null;
            }
        }

        public static string supprimerCategorie(int code)
        {
            object res;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Bdd.getConnexion();
            cmd.CommandText = "DELETE FROM Categorie WHERE code='" + code + "'";
            try
            {
                res = cmd.ExecuteScalar();
                return Convert.ToString(res);
            }
            catch
            {
                return null;
            }
        }

        public static int getMaxCode()
        {
            int res;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Bdd.getConnexion();
            cmd.CommandText = "SELECT MAX(code) FROM Categorie";
            try
            {
                res = (int)cmd.ExecuteScalar();
                return res + 1;
            }
            catch
            {
                return 0;
            }
        }
    }
}
