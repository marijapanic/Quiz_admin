namespace Klijent
{
    partial class IzmenaClana
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
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.gbPodaci = new System.Windows.Forms.GroupBox();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtJMBG = new System.Windows.Forms.TextBox();
            this.txtRBR = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbPodaci.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIzmeni.Location = new System.Drawing.Point(44, 187);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(235, 36);
            this.btnIzmeni.TabIndex = 30;
            this.btnIzmeni.Text = "Sačuvaj izmene";
            this.btnIzmeni.UseVisualStyleBackColor = false;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // gbPodaci
            // 
            this.gbPodaci.Controls.Add(this.txtDatum);
            this.gbPodaci.Controls.Add(this.txtPrezime);
            this.gbPodaci.Controls.Add(this.txtIme);
            this.gbPodaci.Controls.Add(this.txtJMBG);
            this.gbPodaci.Controls.Add(this.txtRBR);
            this.gbPodaci.Controls.Add(this.label6);
            this.gbPodaci.Controls.Add(this.label4);
            this.gbPodaci.Controls.Add(this.label1);
            this.gbPodaci.Controls.Add(this.label3);
            this.gbPodaci.Controls.Add(this.label2);
            this.gbPodaci.Location = new System.Drawing.Point(17, 10);
            this.gbPodaci.Name = "gbPodaci";
            this.gbPodaci.Size = new System.Drawing.Size(288, 171);
            this.gbPodaci.TabIndex = 29;
            this.gbPodaci.TabStop = false;
            this.gbPodaci.Text = "Podaci o članu";
            // 
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(94, 132);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(168, 20);
            this.txtDatum.TabIndex = 38;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(94, 105);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(168, 20);
            this.txtPrezime.TabIndex = 37;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(94, 79);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(168, 20);
            this.txtIme.TabIndex = 36;
            // 
            // txtJMBG
            // 
            this.txtJMBG.Location = new System.Drawing.Point(94, 53);
            this.txtJMBG.Name = "txtJMBG";
            this.txtJMBG.Size = new System.Drawing.Size(168, 20);
            this.txtJMBG.TabIndex = 35;
            // 
            // txtRBR
            // 
            this.txtRBR.Location = new System.Drawing.Point(94, 27);
            this.txtRBR.Name = "txtRBR";
            this.txtRBR.Size = new System.Drawing.Size(168, 20);
            this.txtRBR.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Datum rođenja:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Prezime:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Ime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "JMBG:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Redni broj:";
            // 
            // IzmenaClana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 241);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.gbPodaci);
            this.Name = "IzmenaClana";
            this.Text = "Izmena člana";
            this.Load += new System.EventHandler(this.IzmenaClana_Load);
            this.gbPodaci.ResumeLayout(false);
            this.gbPodaci.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.GroupBox gbPodaci;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtJMBG;
        private System.Windows.Forms.TextBox txtRBR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}