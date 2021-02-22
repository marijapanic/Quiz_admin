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
    public partial class KreiranjeDuela : Form
    {
        KontrolerKI kki = new KontrolerKI();
        bool check = false;

        public KreiranjeDuela()
        {
            InitializeComponent();
            btnSacuvaj.Enabled = false;
            gbDuel.Enabled = false;
            gbTim1.Enabled = false;
            gbTim2.Enabled = false;
        }

        private void KreiranjeDuela_Load(object sender, EventArgs e)
        {
            kki.UcitajTimove(cmbTim1, this);
            kki.UcitajTimove(cmbTim2, this);
            kki.UcitajKvizove(cmbKviz, this);
        }

        private void btnKreiraj_Click(object sender, EventArgs e)
        {
            kki.KreirajDuel(txtID, btnKreiraj, gbDuel, gbTim1, gbTim2, cmbTim1, cmbTim2, btnSacuvaj, this);
            if(btnKreiraj.Enabled == false)
                check = true;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (kki.SacuvajDuel(txtDatumVreme, txtVoditelj, txtRezultat, cmbTim1, cmbTim2, txtD1, cmbKviz, txtG1, btnSacuvaj))
            {
                check = false;
                this.Close();
            } 
        }

        private void KreiranjeDuela_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (check)
            { 
                MessageBox.Show("Pre nego sto izadjete, popunite ovaj duel.");
                e.Cancel = true;
            }
        }
    }
}
