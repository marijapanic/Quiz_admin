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
    public partial class PocetnaForma : Form
    {
        public PocetnaForma()
        {
            InitializeComponent();
        }

        private void evidencijaUplataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new EvidencijaUcesca().ShowDialog();
        }

        private void kreiranjeTimaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new KreiranjeTima().ShowDialog();
        }

        private void pretragaIzmenaBrisanjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PretragaTima().ShowDialog();
        }

        private void kreiranjeDuelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new KreiranjeDuela().ShowDialog();
        }

        private void pretragaDuelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PretragaDuela().ShowDialog();
        }

        private void PocetnaForma_Load(object sender, EventArgs e)
        {

        }

        private void PocetnaForma_FormClosed(object sender, FormClosedEventArgs e)
        {
            /*Login lg = new Login();
            lg.Show();*/
        }
    }
}
