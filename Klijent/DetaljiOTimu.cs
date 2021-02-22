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
    public partial class DetaljiOTimu : Form
    {
        private Tim tim;
        KontrolerKI kki = new KontrolerKI();

        public DetaljiOTimu()
        {
        }

        public DetaljiOTimu(Tim tim)
        {
            InitializeComponent();
            this.tim = tim;
        }

        private void DetaljiOTimu_Load(object sender, EventArgs e)
        {
            kki.PrikaziDetalje(tim, txtID, txtNaziv, dgvClanovi, this);
            dgvClanovi.Columns[5].Visible = false;
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            btnIzmeni.Enabled = false;
            btnSacuvaj.Enabled = true;
            gbTim.Enabled = true;
            gbClanovi.Enabled = true;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            kki.IzmeniTim(tim, txtID, txtNaziv, this);
        }
    }
}
