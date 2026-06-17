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
    public partial class frmAlumno : Form
    {
        public frmAlumno()
        {
            InitializeComponent();
        }

        private void volverALaPáginaPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal frmPrincipal = new frmPrincipal();
                        frmPrincipal.ShowDialog();
        }

        private void volverALaPáginaPrincipalToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            txtDNI.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDireccion.Clear();
            txtContacto.Clear();
            dtpFecha.Value = DateTime.Now;


        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            if (txtDNI == null)
            {
                MessageBox.Show("Ingrese el DNI", "Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            if (txtApellido == null)
            {
                MessageBox.Show("Ingrese el apellido", "Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (txtContacto == null)
            {
                MessageBox.Show("Ingrese el contacto", "Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            if (txtDireccion == null)
            {
                MessageBox.Show("Ingrese una dirección", "Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (txtNombre == null)
            {
                MessageBox.Show("Ingrese el nombre", "Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (dtpFecha.Value > DateTime.Now)
            {
                MessageBox.Show("La fecha de nacimiento no puede ser futura", "Datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
            else
            {
                MessageBox.Show($"DNI: {txtDNI.Text}\nNombre: {txtNombre.Text}\nApellido: {txtApellido.Text}\nDirección: {txtDireccion.Text}\nContacto: {txtContacto.Text}\nFecha de Nacimiento: {dtpFecha.Value.ToShortDateString()}",
                "Información del Alumno", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            
           

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }
    }
}
