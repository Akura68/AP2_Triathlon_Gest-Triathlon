namespace Gest_Triathlon
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.traithlonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesTriathlonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesTriathletesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesInscriptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesÉpreuvesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.résultatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.résultatDesTriathlonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.résultatDesPrélevementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catégoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.traithlonsToolStripMenuItem,
            this.résultatsToolStripMenuItem,
            this.diversToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // traithlonsToolStripMenuItem
            // 
            this.traithlonsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeDesTriathlonsToolStripMenuItem,
            this.listeDesTriathletesToolStripMenuItem,
            this.listeDesInscriptionsToolStripMenuItem,
            this.listeDesÉpreuvesToolStripMenuItem});
            this.traithlonsToolStripMenuItem.Name = "traithlonsToolStripMenuItem";
            this.traithlonsToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.traithlonsToolStripMenuItem.Text = "Triathlons";
            // 
            // listeDesTriathlonsToolStripMenuItem
            // 
            this.listeDesTriathlonsToolStripMenuItem.Name = "listeDesTriathlonsToolStripMenuItem";
            this.listeDesTriathlonsToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.listeDesTriathlonsToolStripMenuItem.Text = "Liste des triathlons";
            this.listeDesTriathlonsToolStripMenuItem.Click += new System.EventHandler(this.listeDesTriathlonsToolStripMenuItem_Click);
            // 
            // listeDesTriathletesToolStripMenuItem
            // 
            this.listeDesTriathletesToolStripMenuItem.Name = "listeDesTriathletesToolStripMenuItem";
            this.listeDesTriathletesToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.listeDesTriathletesToolStripMenuItem.Text = "Liste des triathletes";
            // 
            // listeDesInscriptionsToolStripMenuItem
            // 
            this.listeDesInscriptionsToolStripMenuItem.Name = "listeDesInscriptionsToolStripMenuItem";
            this.listeDesInscriptionsToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.listeDesInscriptionsToolStripMenuItem.Text = "Liste des inscriptions";
            // 
            // listeDesÉpreuvesToolStripMenuItem
            // 
            this.listeDesÉpreuvesToolStripMenuItem.Name = "listeDesÉpreuvesToolStripMenuItem";
            this.listeDesÉpreuvesToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.listeDesÉpreuvesToolStripMenuItem.Text = "Liste des épreuves";
            // 
            // résultatsToolStripMenuItem
            // 
            this.résultatsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.résultatDesTriathlonsToolStripMenuItem,
            this.résultatDesPrélevementsToolStripMenuItem});
            this.résultatsToolStripMenuItem.Name = "résultatsToolStripMenuItem";
            this.résultatsToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.résultatsToolStripMenuItem.Text = "Résultats";
            // 
            // résultatDesTriathlonsToolStripMenuItem
            // 
            this.résultatDesTriathlonsToolStripMenuItem.Name = "résultatDesTriathlonsToolStripMenuItem";
            this.résultatDesTriathlonsToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.résultatDesTriathlonsToolStripMenuItem.Text = "Résultat des triathlons";
            // 
            // résultatDesPrélevementsToolStripMenuItem
            // 
            this.résultatDesPrélevementsToolStripMenuItem.Name = "résultatDesPrélevementsToolStripMenuItem";
            this.résultatDesPrélevementsToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.résultatDesPrélevementsToolStripMenuItem.Text = "Résultat des prélevements";
            // 
            // diversToolStripMenuItem
            // 
            this.diversToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catégoriesToolStripMenuItem,
            this.typesToolStripMenuItem});
            this.diversToolStripMenuItem.Name = "diversToolStripMenuItem";
            this.diversToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.diversToolStripMenuItem.Text = "Divers";
            // 
            // catégoriesToolStripMenuItem
            // 
            this.catégoriesToolStripMenuItem.Name = "catégoriesToolStripMenuItem";
            this.catégoriesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.catégoriesToolStripMenuItem.Text = "Catégories";
            this.catégoriesToolStripMenuItem.Click += new System.EventHandler(this.catégoriesToolStripMenuItem_Click);
            // 
            // typesToolStripMenuItem
            // 
            this.typesToolStripMenuItem.Name = "typesToolStripMenuItem";
            this.typesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.typesToolStripMenuItem.Text = "Types";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Gest-Triathlon";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem traithlonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesTriathlonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesTriathletesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesInscriptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesÉpreuvesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem résultatsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem résultatDesTriathlonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem résultatDesPrélevementsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catégoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typesToolStripMenuItem;
    }
}

