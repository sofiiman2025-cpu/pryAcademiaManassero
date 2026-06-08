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
    public partial class frmCargaPlan : Form
    {
        public frmCargaPlan()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            lstPlanes.Items.Add(cmbNombre.Text);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            cmbNombre.Items.Clear();

            cmbNombre.Items.Add("Plan 1");
            cmbNombre.Items.Add("Plan 2");
            cmbNombre.Items.Add("Plan 3");
        }
    }
}
