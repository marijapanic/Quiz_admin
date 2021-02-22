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
    public partial class DodajClana : Form
    {
        KontrolerKI kki = new KontrolerKI();
        public DodajClana()
        {
            InitializeComponent();
        }

        private void DodajClana_Load(object sender, EventArgs e)
        {

        }

        private void btnDodajClana_Click(object sender, EventArgs e)
        {
            if (kki.DodajClana(txtRBR, txtJMBG, txtIme, txtPrezime, txtDatum))
                this.Close();
        }
    }
}
