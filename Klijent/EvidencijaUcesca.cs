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
    public partial class EvidencijaUcesca : Form
    {
        KontrolerKI kki = new KontrolerKI();

        public EvidencijaUcesca()
        {
            InitializeComponent();
        }

        private void EvidencijaUcesca_Load(object sender, EventArgs e)
        {
            kki.UcitajTimove(dgvTim);
            kki.UcitajKvizove(dgvKviz);
            kki.PopuniUcesca(dgvUcesca);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            kki.DodajUcesce(dgvTim, dgvKviz, txtDatumUplate, txtIznos);
            txtIznos.Text = "";
            txtDatumUplate.Text = "";
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            kki.ObrisiUcesce(dgvUcesca);
        }

        private void btnZapamti_Click(object sender, EventArgs e)
        {
            kki.SacuvajUcesca();
            dgvUcesca.DataSource = null;
        }
    }
}
