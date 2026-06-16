using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
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
        string[] arrayPlanes = new string[10];
        int varIndice = 0;
        
        public frmCargaPlan()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                arrayPlanes[varIndice] = txtNombre.Text;
                MessageBox.Show("Ingrese el plan", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }
            else
            {
                arrayPlanes[varIndice] = txtNombre.Text;
                varIndice++;
                MessageBox.Show("Plan registrado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombre.Clear();
                txtNombre.Focus();
                if (varIndice == 10)
                {
                    btnCargar.Enabled = false;
                }

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            lstPlanes.Items.Clear();
        }
        

        private void btnListar_Click(object sender, EventArgs e)
        {
            lstPlanes.Items.Clear();
            for (int count = 0; count < varIndice; count++)
            {
                if (arrayPlanes[count] != null)
                {
                    lstPlanes.Items.Add(arrayPlanes[count]);
                }
            }

            lstPlanes.Visible = true;
        }

        private void frmCargaPlan_Load(object sender, EventArgs e)
        {

        }

        private void volverALaPáginaPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.ShowDialog();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
