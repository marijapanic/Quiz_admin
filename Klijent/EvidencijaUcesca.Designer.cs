namespace Klijent
{
    partial class EvidencijaUcesca
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
            this.btnZapamti = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.gbUcesce = new System.Windows.Forms.GroupBox();
            this.dgvUcesca = new System.Windows.Forms.DataGridView();
            this.txtIznos = new System.Windows.Forms.TextBox();
            this.txtDatumUplate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbTim = new System.Windows.Forms.GroupBox();
            this.dgvTim = new System.Windows.Forms.DataGridView();
            this.gbKviz = new System.Windows.Forms.GroupBox();
            this.dgvKviz = new System.Windows.Forms.DataGridView();
            this.gbUcesce.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUcesca)).BeginInit();
            this.gbTim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTim)).BeginInit();
            this.gbKviz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKviz)).BeginInit();
            this.SuspendLayout();
            // 
            // btnZapamti
            // 
            this.btnZapamti.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnZapamti.Location = new System.Drawing.Point(443, 339);
            this.btnZapamti.Name = "btnZapamti";
            this.btnZapamti.Size = new System.Drawing.Size(182, 53);
            this.btnZapamti.TabIndex = 19;
            this.btnZapamti.Text = "Zapamti učešća";
            this.btnZapamti.UseVisualStyleBackColor = false;
            this.btnZapamti.Click += new System.EventHandler(this.btnZapamti_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnObrisi.Location = new System.Drawing.Point(98, 369);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(234, 23);
            this.btnObrisi.TabIndex = 18;
            this.btnObrisi.Text = "Obriši učešće";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDodaj.Location = new System.Drawing.Point(514, 183);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(111, 23);
            this.btnDodaj.TabIndex = 17;
            this.btnDodaj.Text = "Dodaj uplatu";
            this.btnDodaj.UseVisualStyleBackColor = false;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // gbUcesce
            // 
            this.gbUcesce.Controls.Add(this.dgvUcesca);
            this.gbUcesce.Location = new System.Drawing.Point(15, 218);
            this.gbUcesce.Name = "gbUcesce";
            this.gbUcesce.Size = new System.Drawing.Size(422, 145);
            this.gbUcesce.TabIndex = 16;
            this.gbUcesce.TabStop = false;
            this.gbUcesce.Text = "Evidencija učešća za odabrani tim";
            // 
            // dgvUcesca
            // 
            this.dgvUcesca.AllowUserToAddRows = false;
            this.dgvUcesca.AllowUserToDeleteRows = false;
            this.dgvUcesca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUcesca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUcesca.Location = new System.Drawing.Point(7, 22);
            this.dgvUcesca.Name = "dgvUcesca";
            this.dgvUcesca.ReadOnly = true;
            this.dgvUcesca.RowHeadersWidth = 4;
            this.dgvUcesca.Size = new System.Drawing.Size(409, 117);
            this.dgvUcesca.TabIndex = 0;
            // 
            // txtIznos
            // 
            this.txtIznos.Location = new System.Drawing.Point(323, 183);
            this.txtIznos.Name = "txtIznos";
            this.txtIznos.Size = new System.Drawing.Size(164, 20);
            this.txtIznos.TabIndex = 15;
            // 
            // txtDatumUplate
            // 
            this.txtDatumUplate.Location = new System.Drawing.Point(98, 183);
            this.txtDatumUplate.Name = "txtDatumUplate";
            this.txtDatumUplate.Size = new System.Drawing.Size(164, 20);
            this.txtDatumUplate.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Iznos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Datum uplate:";
            // 
            // gbTim
            // 
            this.gbTim.Controls.Add(this.dgvTim);
            this.gbTim.Location = new System.Drawing.Point(323, 11);
            this.gbTim.Name = "gbTim";
            this.gbTim.Size = new System.Drawing.Size(302, 162);
            this.gbTim.TabIndex = 11;
            this.gbTim.TabStop = false;
            this.gbTim.Text = "Tim";
            // 
            // dgvTim
            // 
            this.dgvTim.AllowUserToAddRows = false;
            this.dgvTim.AllowUserToDeleteRows = false;
            this.dgvTim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTim.Location = new System.Drawing.Point(7, 20);
            this.dgvTim.Name = "dgvTim";
            this.dgvTim.ReadOnly = true;
            this.dgvTim.RowHeadersWidth = 4;
            this.dgvTim.Size = new System.Drawing.Size(289, 133);
            this.dgvTim.TabIndex = 1;
            // 
            // gbKviz
            // 
            this.gbKviz.Controls.Add(this.dgvKviz);
            this.gbKviz.Location = new System.Drawing.Point(15, 11);
            this.gbKviz.Name = "gbKviz";
            this.gbKviz.Size = new System.Drawing.Size(302, 162);
            this.gbKviz.TabIndex = 10;
            this.gbKviz.TabStop = false;
            this.gbKviz.Text = "Kviz";
            // 
            // dgvKviz
            // 
            this.dgvKviz.AllowUserToAddRows = false;
            this.dgvKviz.AllowUserToDeleteRows = false;
            this.dgvKviz.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKviz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKviz.Location = new System.Drawing.Point(7, 20);
            this.dgvKviz.Name = "dgvKviz";
            this.dgvKviz.ReadOnly = true;
            this.dgvKviz.RowHeadersWidth = 4;
            this.dgvKviz.Size = new System.Drawing.Size(289, 133);
            this.dgvKviz.TabIndex = 0;
            // 
            // EvidencijaUcesca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 402);
            this.Controls.Add(this.btnZapamti);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.gbUcesce);
            this.Controls.Add(this.txtIznos);
            this.Controls.Add(this.txtDatumUplate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbTim);
            this.Controls.Add(this.gbKviz);
            this.Name = "EvidencijaUcesca";
            this.Text = "Evidencija učešća";
            this.Load += new System.EventHandler(this.EvidencijaUcesca_Load);
            this.gbUcesce.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUcesca)).EndInit();
            this.gbTim.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTim)).EndInit();
            this.gbKviz.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKviz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnZapamti;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.GroupBox gbUcesce;
        private System.Windows.Forms.DataGridView dgvUcesca;
        private System.Windows.Forms.TextBox txtIznos;
        private System.Windows.Forms.TextBox txtDatumUplate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbTim;
        private System.Windows.Forms.DataGridView dgvTim;
        private System.Windows.Forms.GroupBox gbKviz;
        private System.Windows.Forms.DataGridView dgvKviz;
    }
}