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

namespace Gest_Triathlon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listeDesTriathlonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListeTriathlons ltn = new ListeTriathlons();
            ltn.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bool ouvert = Bdd.ouvrirConnexion();
            if (ouvert)
                MessageBox.Show(Bdd.afficherConnexion());
            else
                MessageBox.Show("Problème de connexion");
        }

        private void catégoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Catégories cat = new Catégories();
            cat.Show();
        }
    }
}
