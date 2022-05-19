using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classes_Nome
{
    public partial class FrmPrefeito : Form
    {
        public FrmPrefeito()
        {
            InitializeComponent();
        }

        private void FrmPrefeito_Load(object sender, EventArgs e)
        {

        }

        private void prefeitoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPrefeito FrmPrefeito = new FrmPrefeito();
            this.Hide();
            FrmPrefeito.ShowDialog();
        }

        private void lojaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLoja FrmLoja = new FrmLoja();
            this.Hide();
            FrmLoja.ShowDialog();
        }

        private void alimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAlimento FrmAlimento = new FrmAlimento();
            this.Hide();
            FrmAlimento.ShowDialog();
        }
    }
}
