namespace Gest_Triathlon
{
    partial class AddUpdTriathlon
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_id = new System.Windows.Forms.TextBox();
            this.txb_nom = new System.Windows.Forms.TextBox();
            this.cbx_type = new System.Windows.Forms.ComboBox();
            this.cbx_lieu = new System.Windows.Forms.ComboBox();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.bt_valider = new System.Windows.Forms.Button();
            this.bt_annuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lieu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date";
            // 
            // txb_id
            // 
            this.txb_id.Location = new System.Drawing.Point(51, 19);
            this.txb_id.Name = "txb_id";
            this.txb_id.ReadOnly = true;
            this.txb_id.Size = new System.Drawing.Size(100, 20);
            this.txb_id.TabIndex = 5;
            // 
            // txb_nom
            // 
            this.txb_nom.Location = new System.Drawing.Point(51, 46);
            this.txb_nom.Name = "txb_nom";
            this.txb_nom.Size = new System.Drawing.Size(271, 20);
            this.txb_nom.TabIndex = 6;
            // 
            // cbx_type
            // 
            this.cbx_type.FormattingEnabled = true;
            this.cbx_type.Location = new System.Drawing.Point(51, 72);
            this.cbx_type.Name = "cbx_type";
            this.cbx_type.Size = new System.Drawing.Size(212, 21);
            this.cbx_type.TabIndex = 7;
            // 
            // cbx_lieu
            // 
            this.cbx_lieu.FormattingEnabled = true;
            this.cbx_lieu.Location = new System.Drawing.Point(51, 99);
            this.cbx_lieu.Name = "cbx_lieu";
            this.cbx_lieu.Size = new System.Drawing.Size(212, 21);
            this.cbx_lieu.TabIndex = 8;
            // 
            // dtp_date
            // 
            this.dtp_date.Location = new System.Drawing.Point(51, 126);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(228, 20);
            this.dtp_date.TabIndex = 9;
            // 
            // bt_valider
            // 
            this.bt_valider.Location = new System.Drawing.Point(15, 244);
            this.bt_valider.Name = "bt_valider";
            this.bt_valider.Size = new System.Drawing.Size(93, 28);
            this.bt_valider.TabIndex = 10;
            this.bt_valider.Text = "Valider";
            this.bt_valider.UseVisualStyleBackColor = true;
            // 
            // bt_annuler
            // 
            this.bt_annuler.Location = new System.Drawing.Point(141, 244);
            this.bt_annuler.Name = "bt_annuler";
            this.bt_annuler.Size = new System.Drawing.Size(93, 28);
            this.bt_annuler.TabIndex = 11;
            this.bt_annuler.Text = "Annuler";
            this.bt_annuler.UseVisualStyleBackColor = true;
            this.bt_annuler.Click += new System.EventHandler(this.bt_annuler_Click);
            // 
            // AddUpdTriathlon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 304);
            this.Controls.Add(this.bt_annuler);
            this.Controls.Add(this.bt_valider);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.cbx_lieu);
            this.Controls.Add(this.cbx_type);
            this.Controls.Add(this.txb_nom);
            this.Controls.Add(this.txb_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddUpdTriathlon";
            this.Text = "Triathlon";
            this.Load += new System.EventHandler(this.AddUpdTriathlon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txb_id;
        public System.Windows.Forms.TextBox txb_nom;
        public System.Windows.Forms.ComboBox cbx_type;
        public System.Windows.Forms.ComboBox cbx_lieu;
        public System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.Button bt_valider;
        private System.Windows.Forms.Button bt_annuler;
    }
}