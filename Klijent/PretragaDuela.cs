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
    public partial class PretragaDuela : Form
    {
        KontrolerKI kki = new KontrolerKI();

        public PretragaDuela()
        {
            InitializeComponent();
        }

        private void PretragaDuela_Load(object sender, EventArgs e)
        {
            kki.PrikaziDuele(dgvDueli);
            kki.UcitajKvizove(cmbKviz, this);
            dgvDueli.Columns[0].Visible = false;
        }

        private void btnPronadji_Click(object sender, EventArgs e)
        {
            kki.PretraziDuelePoKriterijumu(txtDatum, txtVreme, cmbKviz, dgvDueli, this);
            txtDatum.Text = "";
            txtVreme.Text = "";
            cmbKviz.SelectedItem = null;
        }

        private void btnDetalji_Click(object sender, EventArgs e)
        {
            if (kki.PrikaziDuel(dgvDueli))
            {
                new DetaljiODuelu(dgvDueli.CurrentRow.DataBoundItem as Duel).ShowDialog();
            }
        }
    }
}
