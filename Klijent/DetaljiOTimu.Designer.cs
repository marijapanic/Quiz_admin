namespace Klijent
{
    partial class DetaljiOTimu
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
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.gbClanovi = new System.Windows.Forms.GroupBox();
            this.dgvClanovi = new System.Windows.Forms.DataGridView();
            this.gbTim = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.gbClanovi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanovi)).BeginInit();
            this.gbTim.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSacuvaj.Enabled = false;
            this.btnSacuvaj.Location = new System.Drawing.Point(195, 318);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(149, 23);
            this.btnSacuvaj.TabIndex = 20;
            this.btnSacuvaj.Text = "Sačuvaj izmene";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIzmeni.Location = new System.Drawing.Point(376, 96);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(160, 23);
            this.btnIzmeni.TabIndex = 19;
            this.btnIzmeni.Text = "Izmeni tim";
            this.btnIzmeni.UseVisualStyleBackColor = false;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // gbClanovi
            // 
            this.gbClanovi.Controls.Add(this.dgvClanovi);
            this.gbClanovi.Enabled = false;
            this.gbClanovi.Location = new System.Drawing.Point(18, 122);
            this.gbClanovi.Name = "gbClanovi";
            this.gbClanovi.Size = new System.Drawing.Size(526, 187);
            this.gbClanovi.TabIndex = 18;
            this.gbClanovi.TabStop = false;
            this.gbClanovi.Text = "Članovi";
            // 
            // dgvClanovi
            // 
            this.dgvClanovi.AllowUserToAddRows = false;
            this.dgvClanovi.AllowUserToDeleteRows = false;
            this.dgvClanovi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClanovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClanovi.Location = new System.Drawing.Point(7, 20);
            this.dgvClanovi.Name = "dgvClanovi";
            this.dgvClanovi.RowHeadersWidth = 4;
            this.dgvClanovi.Size = new System.Drawing.Size(511, 150);
            this.dgvClanovi.TabIndex = 0;
            // 
            // gbTim
            // 
            this.gbTim.Controls.Add(this.label2);
            this.gbTim.Controls.Add(this.txtNaziv);
            this.gbTim.Controls.Add(this.label3);
            this.gbTim.Controls.Add(this.txtID);
            this.gbTim.Enabled = false;
            this.gbTim.Location = new System.Drawing.Point(18, 17);
            this.gbTim.Name = "gbTim";
            this.gbTim.Size = new System.Drawing.Size(526, 73);
            this.gbTim.TabIndex = 17;
            this.gbTim.TabStop = false;
            this.gbTim.Text = "Tim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tim ID: ";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(298, 31);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(220, 20);
            this.txtNaziv.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Naziv tima:";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.Info;
            this.txtID.Location = new System.Drawing.Point(51, 31);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(102, 20);
            this.txtID.TabIndex = 10;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DetaljiOTimu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 359);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.gbClanovi);
            this.Controls.Add(this.gbTim);
            this.Name = "DetaljiOTimu";
            this.Text = "Detalji o timu";
            this.Load += new System.EventHandler(this.DetaljiOTimu_Load);
            this.gbClanovi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanovi)).EndInit();
            this.gbTim.ResumeLayout(false);
            this.gbTim.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.GroupBox gbClanovi;
        private System.Windows.Forms.DataGridView dgvClanovi;
        private System.Windows.Forms.GroupBox gbTim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID;
    }
}