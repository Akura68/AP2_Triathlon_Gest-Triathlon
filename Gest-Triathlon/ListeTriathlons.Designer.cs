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
            this.btn_filter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_lieu = new System.Windows.Forms.ComboBox();
            this.cbx_type = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_debut = new System.Windows.Forms.DateTimePicker();
            this.dtp_fin = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_trln)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_trln
            // 
            this.dgv_trln.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_trln.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_trln.Location = new System.Drawing.Point(12, 117);
            this.dgv_trln.Name = "dgv_trln";
            this.dgv_trln.Size = new System.Drawing.Size(776, 321);
            this.dgv_trln.TabIndex = 0;
            this.dgv_trln.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_trln_CellContentDoubleClick);
            this.dgv_trln.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_trln_KeyDown);
            // 
            // btn_filter
            // 
            this.btn_filter.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_filter.Location = new System.Drawing.Point(345, 72);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(106, 39);
            this.btn_filter.TabIndex = 1;
            this.btn_filter.Text = "Filtrer";
            this.btn_filter.UseVisualStyleBackColor = true;
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lieu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Type";
            // 
            // cbx_lieu
            // 
            this.cbx_lieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_lieu.FormattingEnabled = true;
            this.cbx_lieu.Items.AddRange(new object[] {
            " "});
            this.cbx_lieu.Location = new System.Drawing.Point(80, 34);
            this.cbx_lieu.Name = "cbx_lieu";
            this.cbx_lieu.Size = new System.Drawing.Size(147, 21);
            this.cbx_lieu.TabIndex = 4;
            // 
            // cbx_type
            // 
            this.cbx_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_type.FormattingEnabled = true;
            this.cbx_type.Items.AddRange(new object[] {
            " "});
            this.cbx_type.Location = new System.Drawing.Point(80, 69);
            this.cbx_type.Name = "cbx_type";
            this.cbx_type.Size = new System.Drawing.Size(147, 21);
            this.cbx_type.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Entre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(509, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Et";
            // 
            // dtp_debut
            // 
            this.dtp_debut.CustomFormat = "";
            this.dtp_debut.Location = new System.Drawing.Point(326, 30);
            this.dtp_debut.Name = "dtp_debut";
            this.dtp_debut.Size = new System.Drawing.Size(177, 20);
            this.dtp_debut.TabIndex = 8;
            // 
            // dtp_fin
            // 
            this.dtp_fin.Location = new System.Drawing.Point(532, 30);
            this.dtp_fin.Name = "dtp_fin";
            this.dtp_fin.Size = new System.Drawing.Size(177, 20);
            this.dtp_fin.TabIndex = 9;
            // 
            // ListeTriathlons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtp_fin);
            this.Controls.Add(this.dtp_debut);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbx_type);
            this.Controls.Add(this.cbx_lieu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_filter);
            this.Controls.Add(this.dgv_trln);
            this.Name = "ListeTriathlons";
            this.Text = "Liste des triathlons";
            this.Load += new System.EventHandler(this.ListeTriathlons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_trln)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_trln;
        private System.Windows.Forms.Button btn_filter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_lieu;
        private System.Windows.Forms.ComboBox cbx_type;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_debut;
        private System.Windows.Forms.DateTimePicker dtp_fin;
    }
}