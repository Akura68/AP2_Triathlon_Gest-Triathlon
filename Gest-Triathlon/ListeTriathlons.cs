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
                dgv_trln.DataSource = TriathlonDAO.getlesTriathlons();
                foreach (BLL.Triathlon t in TriathlonDAO.getFiltreTriathlons())
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
                dgv_trln.DataSource = TriathlonDAO.getTriathlonsFiltrer(cbx_lieu.Text, cbx_type.Text, dataDebut, dateFin);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du filtrage");
            }
            
        }

        private void dgv_trln_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                var result = MessageBox.Show("Voulez-vous vraiment supprimer le triathlon '" + this.dgv_trln.CurrentRow.Cells[3].Value.ToString() + "' ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Triathlon '" + this.dgv_trln.CurrentRow.Cells[3].Value.ToString() + "' supprimé avec succès!", "Succès!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dgv_trln_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AddUpdTriathlon aut = new AddUpdTriathlon();
            aut.txb_id.Text = this.dgv_trln.CurrentRow.Cells[0].Value.ToString();
            aut.txb_nom.Text = this.dgv_trln.CurrentRow.Cells[3].Value.ToString();
            aut.cbx_type.Text = this.dgv_trln.CurrentRow.Cells[5].Value.ToString();
            aut.cbx_lieu.Text = this.dgv_trln.CurrentRow.Cells[1].Value.ToString();
            aut.dtp_date.Text = this.dgv_trln.CurrentRow.Cells[2].Value.ToString();
            aut.ShowDialog();
        }
    }
}
