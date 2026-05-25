using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gest_Triathlon
{
    public partial class Catégories : Form
    {
        public Catégories()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AddUpdCatégories auc = new AddUpdCatégories();
            //if (this.dgv_cat.CurrentRow.Cells[0].Value.ToString() == "")
            //    auc.tbx_code.Text = Convert.ToString(CatégoriesDAO.getMaxCode());
            //else
            auc.tbx_code.Text = this.dgv_cat.CurrentRow.Cells[0].Value.ToString();
            auc.tbx_libelle.Text = this.dgv_cat.CurrentRow.Cells[1].Value.ToString();
            auc.tbx_agemin.Text = this.dgv_cat.CurrentRow.Cells[2].Value.ToString();
            auc.tbx_agemax.Text = this.dgv_cat.CurrentRow.Cells[3].Value.ToString();
            auc.Show();
        }

        private void Catégories_Load(object sender, EventArgs e)
        {
            bool ouvert = Bdd.ouvrirConnexion();
            if (ouvert)
            {
                dgv_cat.DataSource = CatégoriesDAO.getLesCategories();
            }
        }

        private void dgv_cat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                var result = MessageBox.Show("Voulez-vous vraiment supprimer la catégorie '" + this.dgv_cat.CurrentRow.Cells[1].Value.ToString() + "' ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        CatégoriesDAO.supprimerCategorie(Convert.ToInt16(this.dgv_cat.CurrentRow.Cells[0].Value.ToString()));
                        MessageBox.Show("Catégorie '" + this.dgv_cat.CurrentRow.Cells[1].Value.ToString() + "' supprimé avec succès!", "Succès!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("ERREUR : La catégorie n'as pas pu être supprimée!", "ERREUR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
