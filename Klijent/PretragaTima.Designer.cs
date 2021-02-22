namespace Klijent
{
    partial class PretragaTima
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
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnPrikaziDetalje = new System.Windows.Forms.Button();
            this.dgvTimovi = new System.Windows.Forms.DataGridView();
            this.btnPronadji = new System.Windows.Forms.Button();
            this.txtKriterijum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimovi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnObrisi.Location = new System.Drawing.Point(289, 271);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(136, 23);
            this.btnObrisi.TabIndex = 11;
            this.btnObrisi.Text = "Obriši tim";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnPrikaziDetalje
            // 
            this.btnPrikaziDetalje.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPrikaziDetalje.Location = new System.Drawing.Point(135, 270);
            this.btnPrikaziDetalje.Name = "btnPrikaziDetalje";
            this.btnPrikaziDetalje.Size = new System.Drawing.Size(136, 23);
            this.btnPrikaziDetalje.TabIndex = 10;
            this.btnPrikaziDetalje.Text = "Prikaži detalje o timu";
            this.btnPrikaziDetalje.UseVisualStyleBackColor = false;
            this.btnPrikaziDetalje.Click += new System.EventHandler(this.btnPrikaziDetalje_Click);
            // 
            // dgvTimovi
            // 
            this.dgvTimovi.AllowUserToAddRows = false;
            this.dgvTimovi.AllowUserToDeleteRows = false;
            this.dgvTimovi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTimovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimovi.Location = new System.Drawing.Point(25, 54);
            this.dgvTimovi.Name = "dgvTimovi";
            this.dgvTimovi.ReadOnly = true;
            this.dgvTimovi.RowHeadersWidth = 4;
            this.dgvTimovi.Size = new System.Drawing.Size(501, 210);
            this.dgvTimovi.TabIndex = 9;
            // 
            // btnPronadji
            // 
            this.btnPronadji.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPronadji.Location = new System.Drawing.Point(403, 22);
            this.btnPronadji.Name = "btnPronadji";
            this.btnPronadji.Size = new System.Drawing.Size(123, 23);
            this.btnPronadji.TabIndex = 8;
            this.btnPronadji.Text = "Pronađi";
            this.btnPronadji.UseVisualStyleBackColor = false;
            this.btnPronadji.Click += new System.EventHandler(this.btnPronadji_Click);
            // 
            // txtKriterijum
            // 
            this.txtKriterijum.Location = new System.Drawing.Point(160, 24);
            this.txtKriterijum.Name = "txtKriterijum";
            this.txtKriterijum.Size = new System.Drawing.Size(222, 20);
            this.txtKriterijum.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Unesite kriterijum pretrage:";
            // 
            // PretragaTima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 306);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnPrikaziDetalje);
            this.Controls.Add(this.dgvTimovi);
            this.Controls.Add(this.btnPronadji);
            this.Controls.Add(this.txtKriterijum);
            this.Controls.Add(this.label1);
            this.Name = "PretragaTima";
            this.Text = "Pretraga tima";
            this.Load += new System.EventHandler(this.PretragaTima_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimovi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnPrikaziDetalje;
        private System.Windows.Forms.DataGridView dgvTimovi;
        private System.Windows.Forms.Button btnPronadji;
        private System.Windows.Forms.TextBox txtKriterijum;
        private System.Windows.Forms.Label label1;
    }
}