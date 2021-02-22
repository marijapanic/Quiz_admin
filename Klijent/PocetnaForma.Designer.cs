namespace Klijent
{
    partial class PocetnaForma
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.timoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreiranjeTimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaIzmenaBrisanjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dueliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreiranjeDuelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaDuelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ucescaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evidencijaUplataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timoviToolStripMenuItem,
            this.dueliToolStripMenuItem,
            this.ucescaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(549, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // timoviToolStripMenuItem
            // 
            this.timoviToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kreiranjeTimaToolStripMenuItem,
            this.pretragaIzmenaBrisanjeToolStripMenuItem});
            this.timoviToolStripMenuItem.Name = "timoviToolStripMenuItem";
            this.timoviToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.timoviToolStripMenuItem.Text = "Timovi";
            // 
            // kreiranjeTimaToolStripMenuItem
            // 
            this.kreiranjeTimaToolStripMenuItem.Name = "kreiranjeTimaToolStripMenuItem";
            this.kreiranjeTimaToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.kreiranjeTimaToolStripMenuItem.Text = "Kreiranje tima";
            this.kreiranjeTimaToolStripMenuItem.Click += new System.EventHandler(this.kreiranjeTimaToolStripMenuItem_Click);
            // 
            // pretragaIzmenaBrisanjeToolStripMenuItem
            // 
            this.pretragaIzmenaBrisanjeToolStripMenuItem.Name = "pretragaIzmenaBrisanjeToolStripMenuItem";
            this.pretragaIzmenaBrisanjeToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.pretragaIzmenaBrisanjeToolStripMenuItem.Text = "Pretraga/Izmena/Brisanje";
            this.pretragaIzmenaBrisanjeToolStripMenuItem.Click += new System.EventHandler(this.pretragaIzmenaBrisanjeToolStripMenuItem_Click);
            // 
            // dueliToolStripMenuItem
            // 
            this.dueliToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kreiranjeDuelaToolStripMenuItem,
            this.pretragaDuelaToolStripMenuItem});
            this.dueliToolStripMenuItem.Name = "dueliToolStripMenuItem";
            this.dueliToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dueliToolStripMenuItem.Text = "Dueli";
            // 
            // kreiranjeDuelaToolStripMenuItem
            // 
            this.kreiranjeDuelaToolStripMenuItem.Name = "kreiranjeDuelaToolStripMenuItem";
            this.kreiranjeDuelaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kreiranjeDuelaToolStripMenuItem.Text = "Kreiranje duela";
            this.kreiranjeDuelaToolStripMenuItem.Click += new System.EventHandler(this.kreiranjeDuelaToolStripMenuItem_Click);
            // 
            // pretragaDuelaToolStripMenuItem
            // 
            this.pretragaDuelaToolStripMenuItem.Name = "pretragaDuelaToolStripMenuItem";
            this.pretragaDuelaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pretragaDuelaToolStripMenuItem.Text = "Pretraga duela";
            this.pretragaDuelaToolStripMenuItem.Click += new System.EventHandler(this.pretragaDuelaToolStripMenuItem_Click);
            // 
            // ucescaToolStripMenuItem
            // 
            this.ucescaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.evidencijaUplataToolStripMenuItem});
            this.ucescaToolStripMenuItem.Name = "ucescaToolStripMenuItem";
            this.ucescaToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.ucescaToolStripMenuItem.Text = "Učešća";
            // 
            // evidencijaUplataToolStripMenuItem
            // 
            this.evidencijaUplataToolStripMenuItem.Name = "evidencijaUplataToolStripMenuItem";
            this.evidencijaUplataToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.evidencijaUplataToolStripMenuItem.Text = "Evidencija učešća";
            this.evidencijaUplataToolStripMenuItem.Click += new System.EventHandler(this.evidencijaUplataToolStripMenuItem_Click);
            // 
            // PocetnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 301);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PocetnaForma";
            this.Text = "Početna forma";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PocetnaForma_FormClosed);
            this.Load += new System.EventHandler(this.PocetnaForma_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem timoviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kreiranjeTimaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaIzmenaBrisanjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dueliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kreiranjeDuelaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaDuelaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ucescaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evidencijaUplataToolStripMenuItem;
    }
}