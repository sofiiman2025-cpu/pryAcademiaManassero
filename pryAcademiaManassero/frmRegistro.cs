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

        int varCodigo;
        string varNombre;
        string varPlan;
        bool varActivo;

        public int indiceFila = 0;
        public string[,] matMaterias = new string[10, 5];
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            frmListado frm = new frmListado();
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
                matMaterias[indiceFila, 0] = txtCodigo.Text;
                matMaterias[indiceFila, 1] = txtNombre.Text;
                matMaterias[indiceFila, 2] = cmbPlan.Text;
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
    }
}
