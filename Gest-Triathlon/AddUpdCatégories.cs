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
    public partial class AddUpdCatégories : Form
    {
        public AddUpdCatégories()
        {
            InitializeComponent();
        }

        private void AddUpdCatégories_Load(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if (tbx_code.Text == "")
            {
                CatégoriesDAO.ajouterCategorie(tbx_libelle.Text, tbx_agemin.Text, tbx_agemax.Text);
            }
            else
            {
                CatégoriesDAO.modifierCategorie(Convert.ToInt16(tbx_code.Text), tbx_libelle.Text, tbx_agemin.Text, tbx_agemax.Text);
            }
        }
    }
}
