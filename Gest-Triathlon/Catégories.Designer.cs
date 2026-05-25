namespace Gest_Triathlon
{
    partial class Catégories
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_cat = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cat)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_cat
            // 
            this.dgv_cat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cat.Location = new System.Drawing.Point(12, 12);
            this.dgv_cat.Name = "dgv_cat";
            this.dgv_cat.Size = new System.Drawing.Size(776, 426);
            this.dgv_cat.TabIndex = 0;
            this.dgv_cat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgv_cat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_cat_KeyDown);
            // 
            // Catégories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_cat);
            this.Name = "Catégories";
            this.Text = "Catégories";
            this.Load += new System.EventHandler(this.Catégories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_cat;
    }
}