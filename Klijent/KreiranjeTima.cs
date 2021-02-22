using Biblioteka;
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
    public partial class KreiranjeTima : Form
    {
        KontrolerKI kki = new KontrolerKI();
        bool check = false;

        public KreiranjeTima()
        {
            InitializeComponent();
        }

        private void btnKreirajTim_Click(object sender, EventArgs e)
        {
            kki.KreirajTim(txtID, btnKreirajTim, gbPodaci, dgvClanovi, btnZapamtiTim, this);
            if(btnKreirajTim.Enabled == false)
                check = true;
        }

        private void KreiranjeTima_Load(object sender, EventArgs e)
        {
            gbPodaci.Enabled = false;
        }

        private void btnDodajClana_Click(object sender, EventArgs e)
        {
            DodajClana dodaj = new DodajClana();
            dodaj.ShowDialog();
        }

        private void btnIzmeniClana_Click(object sender, EventArgs e)
        {
            new IzmenaClana(dgvClanovi.CurrentRow.DataBoundItem as Clan).ShowDialog();
        }

        private void btnObrisiClana_Click(object sender, EventArgs e)
        {
            kki.ObrisiClana(dgvClanovi);
        }

        private void btnZapamtiTim_Click(object sender, EventArgs e)
        {
            if (kki.SacuvajTim(txtNaziv, dgvClanovi))
            {
                check = false;
                this.Close();
            }
        }

        private void KreiranjeTima_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (check)
            {
                MessageBox.Show("Pre nego sto izadjete, zavrsite kreiranje tima.");
                e.Cancel = true;
            }
        }
    }
}
