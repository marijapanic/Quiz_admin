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
    public partial class IzmenaClana : Form
    {
        private Clan clan;
        KontrolerKI kki = new KontrolerKI();

        public IzmenaClana(Clan clan)
        {
            InitializeComponent();
            this.clan = clan;
        }

        private void IzmenaClana_Load(object sender, EventArgs e)
        {
            txtRBR.Text = clan.RedBr.ToString();
            txtIme.Text = clan.Ime;
            txtPrezime.Text = clan.Prezime;
            txtJMBG.Text = clan.Jmbg;
            txtDatum.Text = clan.DatumRodjenja.ToString("dd.MM.yyyy");
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (kki.IzmeniClana(clan, txtRBR, txtJMBG, txtIme, txtPrezime, txtDatum))
                this.Close();
        }
    }
}
