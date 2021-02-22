namespace Server
{
    partial class FormServer
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
            this.btnZaustavi = new System.Windows.Forms.Button();
            this.btnPokreni = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnZaustavi
            // 
            this.btnZaustavi.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnZaustavi.Enabled = false;
            this.btnZaustavi.Location = new System.Drawing.Point(225, 22);
            this.btnZaustavi.Name = "btnZaustavi";
            this.btnZaustavi.Size = new System.Drawing.Size(195, 42);
            this.btnZaustavi.TabIndex = 3;
            this.btnZaustavi.Text = "Zaustavi server";
            this.btnZaustavi.UseVisualStyleBackColor = false;
            this.btnZaustavi.Click += new System.EventHandler(this.btnZaustavi_Click);
            // 
            // btnPokreni
            // 
            this.btnPokreni.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPokreni.Location = new System.Drawing.Point(12, 22);
            this.btnPokreni.Name = "btnPokreni";
            this.btnPokreni.Size = new System.Drawing.Size(195, 42);
            this.btnPokreni.TabIndex = 2;
            this.btnPokreni.Text = "Pokreni server";
            this.btnPokreni.UseVisualStyleBackColor = false;
            this.btnPokreni.Click += new System.EventHandler(this.btnPokreni_Click);
            // 
            // FormServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 99);
            this.Controls.Add(this.btnZaustavi);
            this.Controls.Add(this.btnPokreni);
            this.Name = "FormServer";
            this.Text = "Server forma";
            this.Load += new System.EventHandler(this.FormServer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnZaustavi;
        private System.Windows.Forms.Button btnPokreni;
    }
}

