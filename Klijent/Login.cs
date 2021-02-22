using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent
{
    public partial class Login : Form
    {
        KontrolerKI kki = new KontrolerKI();
        public Login()
        {
            InitializeComponent();
          // if (k.poveziSeNaServer()) this.Text = "Povezan!";
        }

        private void FormKlijent_Load(object sender, EventArgs e)
        {

        }

        private void FormKlijent_FormClosed(object sender, FormClosedEventArgs e)
        {
            KontrolerKI.odjaviSeSaServera();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            this.Text = KontrolerKI.poveziSeNaServer();
            if (kki.PrijaviSe(txtIme, txtSifra))
            {
                PocetnaForma p = new PocetnaForma();
                this.Hide();
                this.Owner = p;
                p.Show();
            }
        }
    }
}
