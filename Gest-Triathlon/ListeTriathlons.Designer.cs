namespace Gest_Triathlon
{
    partial class ListeTriathlons
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
            this.dgv_trln = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_trln)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_trln
            // 
            this.dgv_trln.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_trln.Location = new System.Drawing.Point(12, 117);
            this.dgv_trln.Name = "dgv_trln";
            this.dgv_trln.Size = new System.Drawing.Size(776, 321);
            this.dgv_trln.TabIndex = 0;
            // 
            // ListeTriathlons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_trln);
            this.Name = "ListeTriathlons";
            this.Text = "Liste des triathlons";
            this.Load += new System.EventHandler(this.ListeTriathlons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_trln)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_trln;
    }
}