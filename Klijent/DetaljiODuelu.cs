using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteka;

namespace Klijent
{
    public partial class DetaljiODuelu : Form
    {
        private Duel duel;
        KontrolerKI kki = new KontrolerKI();

        public DetaljiODuelu()
        {
        }

        public DetaljiODuelu(Duel duel)
        {
            InitializeComponent();
            this.duel = duel;
        }

        private void DetaljiODuelu_Load(object sender, EventArgs e)
        {
            kki.PrikaziDetaljeODuelu(duel, txtDatumVreme, txtKviz, txtVoditelj, txtTim1, txtTim2, txtP1, txtP2, this);
        }
    }
}
