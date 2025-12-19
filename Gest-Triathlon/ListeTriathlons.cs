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
            }
        }
    }
}
