namespace Klijent
{
    partial class KreiranjeTima
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
            this.btnZapamtiTim = new System.Windows.Forms.Button();
            this.gbPodaci = new System.Windows.Forms.GroupBox();
            this.btnObrisiClana = new System.Windows.Forms.Button();
            this.btnIzmeniClana = new System.Windows.Forms.Button();
            this.btnDodajClana = new System.Windows.Forms.Button();
            this.dgvClanovi = new System.Windows.Forms.DataGridView();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKreirajTim = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbPodaci.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanovi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnZapamtiTim
            // 
            this.btnZapamtiTim.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnZapamtiTim.Enabled = false;
            this.btnZapamtiTim.Location = new System.Drawing.Point(166, 353);
            this.btnZapamtiTim.Name = "btnZapamtiTim";
            this.btnZapamtiTim.Size = new System.Drawing.Size(209, 33);
            this.btnZapamtiTim.TabIndex = 32;
            this.btnZapamtiTim.Text = "Zapamti podatke o timu";
            this.btnZapamtiTim.UseVisualStyleBackColor = false;
            this.btnZapamtiTim.Click += new System.EventHandler(this.btnZapamtiTim_Click);
            // 
            // gbPodaci
            // 
            this.gbPodaci.BackColor = System.Drawing.SystemColors.Control;
            this.gbPodaci.Controls.Add(this.btnObrisiClana);
            this.gbPodaci.Controls.Add(this.btnIzmeniClana);
            this.gbPodaci.Controls.Add(this.btnDodajClana);
            this.gbPodaci.Controls.Add(this.dgvClanovi);
            this.gbPodaci.Controls.Add(this.txtNaziv);
            this.gbPodaci.Controls.Add(this.label2);
            this.gbPodaci.Location = new System.Drawing.Point(17, 57);
            this.gbPodaci.Name = "gbPodaci";
            this.gbPodaci.Size = new System.Drawing.Size(491, 290);
            this.gbPodaci.TabIndex = 31;
            this.gbPodaci.TabStop = false;
            this.gbPodaci.Text = "Podaci o timu";
            // 
            // btnObrisiClana
            // 
            this.btnObrisiClana.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnObrisiClana.Location = new System.Drawing.Point(352, 68);
            this.btnObrisiClana.Name = "btnObrisiClana";
            this.btnObrisiClana.Size = new System.Drawing.Size(128, 36);
            this.btnObrisiClana.TabIndex = 27;
            this.btnObrisiClana.Text = "Obriši člana";
            this.btnObrisiClana.UseVisualStyleBackColor = false;
            this.btnObrisiClana.Click += new System.EventHandler(this.btnObrisiClana_Click);
            // 
            // btnIzmeniClana
            // 
            this.btnIzmeniClana.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIzmeniClana.Location = new System.Drawing.Point(186, 68);
            this.btnIzmeniClana.Name = "btnIzmeniClana";
            this.btnIzmeniClana.Size = new System.Drawing.Size(128, 36);
            this.btnIzmeniClana.TabIndex = 26;
            this.btnIzmeniClana.Text = "Izmeni člana";
            this.btnIzmeniClana.UseVisualStyleBackColor = false;
            this.btnIzmeniClana.Click += new System.EventHandler(this.btnIzmeniClana_Click);
            // 
            // btnDodajClana
            // 
            this.btnDodajClana.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDodajClana.Location = new System.Drawing.Point(19, 68);
            this.btnDodajClana.Name = "btnDodajClana";
            this.btnDodajClana.Size = new System.Drawing.Size(128, 36);
            this.btnDodajClana.TabIndex = 25;
            this.btnDodajClana.Text = "Dodaj člana";
            this.btnDodajClana.UseVisualStyleBackColor = false;
            this.btnDodajClana.Click += new System.EventHandler(this.btnDodajClana_Click);
            // 
            // dgvClanovi
            // 
            this.dgvClanovi.AllowUserToAddRows = false;
            this.dgvClanovi.AllowUserToDeleteRows = false;
            this.dgvClanovi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClanovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClanovi.Location = new System.Drawing.Point(19, 111);
            this.dgvClanovi.Name = "dgvClanovi";
            this.dgvClanovi.ReadOnly = true;
            this.dgvClanovi.RowHeadersWidth = 4;
            this.dgvClanovi.Size = new System.Drawing.Size(461, 165);
            this.dgvClanovi.TabIndex = 24;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(82, 27);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(401, 20);
            this.txtNaziv.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Naziv tima:";
            // 
            // btnKreirajTim
            // 
            this.btnKreirajTim.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnKreirajTim.Location = new System.Drawing.Point(166, 23);
            this.btnKreirajTim.Name = "btnKreirajTim";
            this.btnKreirajTim.Size = new System.Drawing.Size(334, 23);
            this.btnKreirajTim.TabIndex = 30;
            this.btnKreirajTim.Text = "Kreiraj tim";
            this.btnKreirajTim.UseVisualStyleBackColor = false;
            this.btnKreirajTim.Click += new System.EventHandler(this.btnKreirajTim_Click);
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.Info;
            this.txtID.Location = new System.Drawing.Point(98, 25);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(47, 20);
            this.txtID.TabIndex = 29;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Tim ID:";
            // 
            // KreiranjeTima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 392);
            this.Controls.Add(this.btnZapamtiTim);
            this.Controls.Add(this.gbPodaci);
            this.Controls.Add(this.btnKreirajTim);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Name = "KreiranjeTima";
            this.Text = "Kreiranje novog tima";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KreiranjeTima_FormClosing);
            this.Load += new System.EventHandler(this.KreiranjeTima_Load);
            this.gbPodaci.ResumeLayout(false);
            this.gbPodaci.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClanovi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnZapamtiTim;
        private System.Windows.Forms.GroupBox gbPodaci;
        private System.Windows.Forms.Button btnObrisiClana;
        private System.Windows.Forms.Button btnIzmeniClana;
        private System.Windows.Forms.Button btnDodajClana;
        private System.Windows.Forms.DataGridView dgvClanovi;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKreirajTim;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
    }
}