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
        int varInice = 0;
        
        public frmCargaPlan()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                arrayPlanes[varInice] = txtNombre.Text;
                MessageBox.Show("Ingrese el plan", "Carga de planes", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtNombre.Focus();
                return;

            }
            else
            {
                arrayPlanes[varInice] = txtNombre.Text;
                varInice++;
                MessageBox.Show("Plan cargado correctamente", "Carga de planes", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                txtNombre.Focus();
                return;
                if (varInice >= arrayPlanes.Length)
                {
                    btnCargar.Enabled = false;
                }
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {


        }

        private void frmCargaPlan_Load(object sender, EventArgs e)
        {

        }
    }
}
