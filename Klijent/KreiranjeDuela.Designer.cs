namespace Klijent
{
    partial class KreiranjeDuela
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
            this.btnKreiraj = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.gbDuel = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDatumVreme = new System.Windows.Forms.TextBox();
            this.txtVoditelj = new System.Windows.Forms.TextBox();
            this.cmbKviz = new System.Windows.Forms.ComboBox();
            this.txtRezultat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbTim1 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbTim1 = new System.Windows.Forms.ComboBox();
            this.txtD1 = new System.Windows.Forms.TextBox();
            this.gbTim2 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtG1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbTim2 = new System.Windows.Forms.ComboBox();
            this.gbDuel.SuspendLayout();
            this.gbTim1.SuspendLayout();
            this.gbTim2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSacuvaj.Location = new System.Drawing.Point(160, 255);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(192, 28);
            this.btnSacuvaj.TabIndex = 31;
            this.btnSacuvaj.Text = "Zapamti duel";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // btnKreiraj
            // 
            this.btnKreiraj.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnKreiraj.Location = new System.Drawing.Point(169, 12);
            this.btnKreiraj.Name = "btnKreiraj";
            this.btnKreiraj.Size = new System.Drawing.Size(311, 23);
            this.btnKreiraj.TabIndex = 30;
            this.btnKreiraj.Text = "Kreiraj duel";
            this.btnKreiraj.UseVisualStyleBackColor = false;
            this.btnKreiraj.Click += new System.EventHandler(this.btnKreiraj_Click);
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.Info;
            this.txtID.Location = new System.Drawing.Point(93, 14);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(53, 20);
            this.txtID.TabIndex = 29;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbDuel
            // 
            this.gbDuel.Controls.Add(this.label18);
            this.gbDuel.Controls.Add(this.label5);
            this.gbDuel.Controls.Add(this.label4);
            this.gbDuel.Controls.Add(this.label2);
            this.gbDuel.Controls.Add(this.txtDatumVreme);
            this.gbDuel.Controls.Add(this.txtVoditelj);
            this.gbDuel.Controls.Add(this.cmbKviz);
            this.gbDuel.Controls.Add(this.txtRezultat);
            this.gbDuel.Location = new System.Drawing.Point(12, 48);
            this.gbDuel.Name = "gbDuel";
            this.gbDuel.Size = new System.Drawing.Size(468, 89);
            this.gbDuel.TabIndex = 28;
            this.gbDuel.TabStop = false;
            this.gbDuel.Text = "Podaci o duelu";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(262, 28);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(30, 13);
            this.label18.TabIndex = 10;
            this.label18.Text = "Kviz:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(262, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Rezultat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Voditelj:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Datum i vreme održavanja:";
            // 
            // txtDatumVreme
            // 
            this.txtDatumVreme.Location = new System.Drawing.Point(148, 25);
            this.txtDatumVreme.Name = "txtDatumVreme";
            this.txtDatumVreme.Size = new System.Drawing.Size(100, 20);
            this.txtDatumVreme.TabIndex = 7;
            // 
            // txtVoditelj
            // 
            this.txtVoditelj.Location = new System.Drawing.Point(148, 50);
            this.txtVoditelj.Name = "txtVoditelj";
            this.txtVoditelj.Size = new System.Drawing.Size(100, 20);
            this.txtVoditelj.TabIndex = 8;
            // 
            // cmbKviz
            // 
            this.cmbKviz.FormattingEnabled = true;
            this.cmbKviz.Location = new System.Drawing.Point(314, 25);
            this.cmbKviz.Name = "cmbKviz";
            this.cmbKviz.Size = new System.Drawing.Size(121, 21);
            this.cmbKviz.TabIndex = 9;
            // 
            // txtRezultat
            // 
            this.txtRezultat.Location = new System.Drawing.Point(314, 50);
            this.txtRezultat.Name = "txtRezultat";
            this.txtRezultat.Size = new System.Drawing.Size(121, 20);
            this.txtRezultat.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Duel ID:";
            // 
            // gbTim1
            // 
            this.gbTim1.Controls.Add(this.label16);
            this.gbTim1.Controls.Add(this.label6);
            this.gbTim1.Controls.Add(this.cmbTim1);
            this.gbTim1.Controls.Add(this.txtD1);
            this.gbTim1.Location = new System.Drawing.Point(18, 143);
            this.gbTim1.Name = "gbTim1";
            this.gbTim1.Size = new System.Drawing.Size(224, 97);
            this.gbTim1.TabIndex = 26;
            this.gbTim1.TabStop = false;
            this.gbTim1.Text = "Tim 1";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(11, 30);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 13);
            this.label16.TabIndex = 15;
            this.label16.Text = "Tim 1:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Poeni:";
            // 
            // cmbTim1
            // 
            this.cmbTim1.FormattingEnabled = true;
            this.cmbTim1.Location = new System.Drawing.Point(97, 27);
            this.cmbTim1.Name = "cmbTim1";
            this.cmbTim1.Size = new System.Drawing.Size(105, 21);
            this.cmbTim1.TabIndex = 12;
            // 
            // txtD1
            // 
            this.txtD1.Location = new System.Drawing.Point(148, 56);
            this.txtD1.Name = "txtD1";
            this.txtD1.Size = new System.Drawing.Size(54, 20);
            this.txtD1.TabIndex = 13;
            // 
            // gbTim2
            // 
            this.gbTim2.Controls.Add(this.label17);
            this.gbTim2.Controls.Add(this.txtG1);
            this.gbTim2.Controls.Add(this.label15);
            this.gbTim2.Controls.Add(this.cmbTim2);
            this.gbTim2.Location = new System.Drawing.Point(248, 143);
            this.gbTim2.Name = "gbTim2";
            this.gbTim2.Size = new System.Drawing.Size(224, 97);
            this.gbTim2.TabIndex = 27;
            this.gbTim2.TabStop = false;
            this.gbTim2.Text = "Tim 2";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 30);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(36, 13);
            this.label17.TabIndex = 16;
            this.label17.Text = "Tim 2:";
            // 
            // txtG1
            // 
            this.txtG1.Location = new System.Drawing.Point(154, 56);
            this.txtG1.Name = "txtG1";
            this.txtG1.Size = new System.Drawing.Size(54, 20);
            this.txtG1.TabIndex = 19;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 59);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "Poeni:";
            // 
            // cmbTim2
            // 
            this.cmbTim2.FormattingEnabled = true;
            this.cmbTim2.Location = new System.Drawing.Point(103, 27);
            this.cmbTim2.Name = "cmbTim2";
            this.cmbTim2.Size = new System.Drawing.Size(105, 21);
            this.cmbTim2.TabIndex = 18;
            // 
            // KreiranjeDuela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 296);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.btnKreiraj);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.gbDuel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbTim1);
            this.Controls.Add(this.gbTim2);
            this.Name = "KreiranjeDuela";
            this.Text = "Kreiranje duela";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KreiranjeDuela_FormClosing);
            this.Load += new System.EventHandler(this.KreiranjeDuela_Load);
            this.gbDuel.ResumeLayout(false);
            this.gbDuel.PerformLayout();
            this.gbTim1.ResumeLayout(false);
            this.gbTim1.PerformLayout();
            this.gbTim2.ResumeLayout(false);
            this.gbTim2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnKreiraj;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.GroupBox gbDuel;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDatumVreme;
        private System.Windows.Forms.TextBox txtVoditelj;
        private System.Windows.Forms.ComboBox cmbKviz;
        private System.Windows.Forms.TextBox txtRezultat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbTim1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbTim1;
        private System.Windows.Forms.TextBox txtD1;
        private System.Windows.Forms.GroupBox gbTim2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtG1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbTim2;
    }
}