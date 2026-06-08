using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryAcademiaManassero
{
    public partial class frmPrincipal : Form
    {
        
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void materiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegistro frmRegistro = new frmRegistro();
            frmRegistro.ShowDialog();
        }

        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmListado frmListado = new frmListado();
            frmListado.ShowDialog();

        }

        private void menuCarga_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCargaPlan frmCargaPlan = new frmCargaPlan();
            frmCargaPlan.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
          
        }
    }
}
