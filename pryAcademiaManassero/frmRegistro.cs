using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace pryAcademiaManassero
{
    public partial class frmRegistro : Form
    {
        public DateTime varInicioSesion;

        

        public int indiceFila = 0;
        public string[,] matMaterias = new string[10, 5];
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            frmListado frm = new frmListado();
            // Pass the current matrix to the list form so the grid can display it
            frm.arrListado = matMaterias;
            frm.Show();
           
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string estado;

            if (string.IsNullOrWhiteSpace(txtCodigo.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                cmbPlan.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor complete todos los campos antes de continuar.", "Campos incompletos",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (indiceFila >= matMaterias.GetLength(0))
                {
                    MessageBox.Show("No se pueden registrar más filas.", "Límite alcanzado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                matMaterias[indiceFila, 0] = txtCodigo.Text;
                matMaterias[indiceFila, 1] = txtNombre.Text;
                matMaterias[indiceFila, 2] = cmbPlan.Text;
                matMaterias[indiceFila,3] = chkActivo.Checked ? "Activo" : "Inactivo";
                indiceFila++; //Apuntamos a la siguiente fila para el próximo registro
            }

            if (chkActivo.Checked)
            {
                estado = "Activo";
            }
            else
            {
                estado = "Inactivo";
            }

            matMaterias[indiceFila, 3] = estado;

            MessageBox.Show(
              "Registro completo\n\n" +
              "Código: " + txtCodigo.Text +
              "\nNombre: " + txtNombre.Text +
                "\nPlan: " + cmbPlan.SelectedItem.ToString() +
                "\nEstado: " + estado);

            // Increment the index so the next registration goes to the next row
            indiceFila++;

            txtCodigo.Clear();
            txtNombre.Clear();
            cmbPlan.Items.Clear();
            chkActivo.Checked = false;


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
            txtCodigo.Clear();
            txtNombre.Clear();
            cmbPlan.SelectedIndex = -1;
            chkActivo.Checked = false;
        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {

        }

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.ShowDialog();
        }

        private void pRegistro_Paint(object sender, PaintEventArgs e)
        {
        
        }

        private void btnRegistrar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnRegistrar.PerformClick();
            }
        }

        private void volverALaPáginaPricnipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; //Solo deje ingresar dígitos y teclas de control 
            }
        }
    }
}
