namespace Gest_Triathlon
{
    partial class AddUpdCatégories
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
            this.tbx_code = new System.Windows.Forms.TextBox();
            this.Code = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_libelle = new System.Windows.Forms.TextBox();
            this.tbx_agemin = new System.Windows.Forms.TextBox();
            this.tbx_agemax = new System.Windows.Forms.TextBox();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbx_code
            // 
            this.tbx_code.Location = new System.Drawing.Point(72, 18);
            this.tbx_code.Name = "tbx_code";
            this.tbx_code.ReadOnly = true;
            this.tbx_code.Size = new System.Drawing.Size(100, 20);
            this.tbx_code.TabIndex = 0;
            // 
            // Code
            // 
            this.Code.AutoSize = true;
            this.Code.Location = new System.Drawing.Point(12, 21);
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(38, 13);
            this.Code.TabIndex = 1;
            this.Code.Text = "Code :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Libelle :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Age min :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Age max :";
            // 
            // tbx_libelle
            // 
            this.tbx_libelle.Location = new System.Drawing.Point(72, 60);
            this.tbx_libelle.Name = "tbx_libelle";
            this.tbx_libelle.Size = new System.Drawing.Size(100, 20);
            this.tbx_libelle.TabIndex = 5;
            // 
            // tbx_agemin
            // 
            this.tbx_agemin.Location = new System.Drawing.Point(72, 100);
            this.tbx_agemin.Name = "tbx_agemin";
            this.tbx_agemin.Size = new System.Drawing.Size(100, 20);
            this.tbx_agemin.TabIndex = 6;
            // 
            // tbx_agemax
            // 
            this.tbx_agemax.Location = new System.Drawing.Point(72, 147);
            this.tbx_agemax.Name = "tbx_agemax";
            this.tbx_agemax.Size = new System.Drawing.Size(100, 20);
            this.tbx_agemax.TabIndex = 7;
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(15, 231);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(75, 23);
            this.btn_confirm.TabIndex = 8;
            this.btn_confirm.Text = "Confirmer";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(131, 231);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 9;
            this.btn_cancel.Text = "Annuler";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // AddUpdCatégories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 450);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.tbx_agemax);
            this.Controls.Add(this.tbx_agemin);
            this.Controls.Add(this.tbx_libelle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Code);
            this.Controls.Add(this.tbx_code);
            this.Name = "AddUpdCatégories";
            this.Text = "AddUpdCatégories";
            this.Load += new System.EventHandler(this.AddUpdCatégories_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Code;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbx_code;
        public System.Windows.Forms.TextBox tbx_libelle;
        public System.Windows.Forms.TextBox tbx_agemin;
        public System.Windows.Forms.TextBox tbx_agemax;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Button btn_cancel;
    }
}