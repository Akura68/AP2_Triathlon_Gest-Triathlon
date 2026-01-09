using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;
using MySql.Data.MySqlClient;

namespace Gest_Triathlon
{
    public partial class ListeTriathlons : Form
    {
        public ListeTriathlons()
        {
            InitializeComponent();
        }

        private void ListeTriathlons_Load(object sender, EventArgs e)
        {
            bool ouvert = Bdd.ouvrirConnexion();
            if (ouvert)
            {
                dgv_trln.DataSource = Bdd.getlesTriathlons();
                foreach (Triathlon t in Bdd.getFiltreTriathlons())
                {
                    cbx_lieu.Items.Add(t.getLieuT());
                    cbx_type.Items.Add(t.getLibelleType());
                }
            }
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            string dataDebut = dtp_debut.Value.Year + "-" + dtp_debut.Value.Month + "-" + dtp_debut.Value.Day;
            string dateFin = dtp_fin.Value.Year + "-" + dtp_fin.Value.Month + "-" + dtp_fin.Value.Day;
            try
            {
                dgv_trln.DataSource = Bdd.getTriathlonsFiltrer(cbx_lieu.Text, cbx_type.Text, dataDebut, dateFin);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du filtrage");
            }
            
        }
    }
}
