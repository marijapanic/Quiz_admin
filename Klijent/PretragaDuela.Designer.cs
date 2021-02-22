namespace Klijent
{
    partial class PretragaDuela
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
            this.btnDetalji = new System.Windows.Forms.Button();
            this.dgvDueli = new System.Windows.Forms.DataGridView();
            this.gbPretraga = new System.Windows.Forms.GroupBox();
            this.btnPronadji = new System.Windows.Forms.Button();
            this.txtVreme = new System.Windows.Forms.TextBox();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbKviz = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDueli)).BeginInit();
            this.gbPretraga.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDetalji
            // 
            this.btnDetalji.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDetalji.Location = new System.Drawing.Point(206, 329);
            this.btnDetalji.Name = "btnDetalji";
            this.btnDetalji.Size = new System.Drawing.Size(234, 28);
            this.btnDetalji.TabIndex = 5;
            this.btnDetalji.Text = "Prikaži detalje o duelu";
            this.btnDetalji.UseVisualStyleBackColor = false;
            this.btnDetalji.Click += new System.EventHandler(this.btnDetalji_Click);
            // 
            // dgvDueli
            // 
            this.dgvDueli.AllowUserToAddRows = false;
            this.dgvDueli.AllowUserToDeleteRows = false;
            this.dgvDueli.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDueli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDueli.Location = new System.Drawing.Point(9, 111);
            this.dgvDueli.Name = "dgvDueli";
            this.dgvDueli.ReadOnly = true;
            this.dgvDueli.RowHeadersWidth = 4;
            this.dgvDueli.Size = new System.Drawing.Size(641, 203);
            this.dgvDueli.TabIndex = 4;
            // 
            // gbPretraga
            // 
            this.gbPretraga.Controls.Add(this.cmbKviz);
            this.gbPretraga.Controls.Add(this.label3);
            this.gbPretraga.Controls.Add(this.btnPronadji);
            this.gbPretraga.Controls.Add(this.txtVreme);
            this.gbPretraga.Controls.Add(this.txtDatum);
            this.gbPretraga.Controls.Add(this.label2);
            this.gbPretraga.Controls.Add(this.label1);
            this.gbPretraga.Location = new System.Drawing.Point(9, 7);
            this.gbPretraga.Name = "gbPretraga";
            this.gbPretraga.Size = new System.Drawing.Size(641, 98);
            this.gbPretraga.TabIndex = 3;
            this.gbPretraga.TabStop = false;
            this.gbPretraga.Text = "Kriterijum pretrage";
            // 
            // btnPronadji
            // 
            this.btnPronadji.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPronadji.Location = new System.Drawing.Point(197, 62);
            this.btnPronadji.Name = "btnPronadji";
            this.btnPronadji.Size = new System.Drawing.Size(234, 27);
            this.btnPronadji.TabIndex = 8;
            this.btnPronadji.Text = "Pronađi duele";
            this.btnPronadji.UseVisualStyleBackColor = false;
            this.btnPronadji.Click += new System.EventHandler(this.btnPronadji_Click);
            // 
            // txtVreme
            // 
            this.txtVreme.Location = new System.Drawing.Point(259, 28);
            this.txtVreme.Name = "txtVreme";
            this.txtVreme.Size = new System.Drawing.Size(143, 20);
            this.txtVreme.TabIndex = 5;
            // 
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(49, 28);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(138, 20);
            this.txtDatum.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vreme:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datum:";
            // 
            // cmbKviz
            // 
            this.cmbKviz.FormattingEnabled = true;
            this.cmbKviz.Location = new System.Drawing.Point(469, 28);
            this.cmbKviz.Name = "cmbKviz";
            this.cmbKviz.Size = new System.Drawing.Size(156, 21);
            this.cmbKviz.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(424, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Kviz:";
            // 
            // PretragaDuela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 368);
            this.Controls.Add(this.btnDetalji);
            this.Controls.Add(this.dgvDueli);
            this.Controls.Add(this.gbPretraga);
            this.Name = "PretragaDuela";
            this.Text = "Pretraga duela";
            this.Load += new System.EventHandler(this.PretragaDuela_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDueli)).EndInit();
            this.gbPretraga.ResumeLayout(false);
            this.gbPretraga.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDetalji;
        private System.Windows.Forms.DataGridView dgvDueli;
        private System.Windows.Forms.GroupBox gbPretraga;
        private System.Windows.Forms.Button btnPronadji;
        private System.Windows.Forms.TextBox txtVreme;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKviz;
        private System.Windows.Forms.Label label3;
    }
}