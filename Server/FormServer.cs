using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class FormServer : Form
    {
        Server s;
        public FormServer()
        {
            InitializeComponent();
        }

        private void FormServer_Load(object sender, EventArgs e)
        {

        }

        private void btnPokreni_Click(object sender, EventArgs e)
        {
            s = new Server();
            if (s.pokreniServer())
            {
                this.Text = "Server je pokrenut!";
                btnPokreni.Enabled = false;
                btnZaustavi.Enabled = true;
            }
        }

        private void btnZaustavi_Click(object sender, EventArgs e)
        {
            if (Server.klijenti.Count > 0)
            {
                MessageBox.Show("Ima još ulogovanih klijenata!");
                return;
            }

            if (s.zaustaviServer())
            {
                this.Text = "Server nije pokrenut!";
                btnPokreni.Enabled = true;
                btnZaustavi.Enabled = false;
            }
        }
    }
}
