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
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            frmListado frmListado = new frmListado();
            this.Hide();
            frmListado.ShowDialog();
            this.Show();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                cmbPlan.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor complete todos los campos antes de continuar.", "Campos incompletos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void btnCarga_Click(object sender, EventArgs e)
        {
            frmCargaPlan frmCargaPlan = new frmCargaPlan();
            this.Hide();
                        frmCargaPlan.ShowDialog();
            this.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
