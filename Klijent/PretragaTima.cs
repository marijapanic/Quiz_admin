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
    public partial class PretragaTima : Form
    {
        KontrolerKI kki = new KontrolerKI();
        public PretragaTima()
        {
            InitializeComponent();
        }

        private void PretragaTima_Load(object sender, EventArgs e)
        {
            kki.PrikaziDetaljeOTimu(dgvTimovi, txtKriterijum);
            dgvTimovi.Columns[0].Visible = false;
        }

        private void btnPronadji_Click(object sender, EventArgs e)
        {
            kki.PretraziTimovePoKriterijumu(dgvTimovi, txtKriterijum, this);
        }

        private void btnPrikaziDetalje_Click(object sender, EventArgs e)
        {
            if (kki.PrikaziTim(dgvTimovi))
            {
                new DetaljiOTimu(dgvTimovi.CurrentRow.DataBoundItem as Tim).ShowDialog();
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            kki.ObrisiTim(dgvTimovi);
            kki.PrikaziDetaljeOTimu(dgvTimovi, txtKriterijum);
        }
    }
}
