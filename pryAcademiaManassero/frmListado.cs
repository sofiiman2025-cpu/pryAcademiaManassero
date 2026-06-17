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
    public partial class frmListado : Form
    {
        public string[,] arrListado = new string[4, 5]; //También asignado a frmRegistro
        public frmListado()
        {
            InitializeComponent();
        }

        private void frmListado_Load(object sender, EventArgs e)
        {
            dgvListado.Columns.Add("Codigo", "Código");
            dgvListado.Columns.Add("Nombre", "Nombre");
            dgvListado.Columns.Add("Plan", "Plan");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvListado.Rows.Clear();

            if (!rdbCodigo.Checked && !rdbNombre.Checked && !rdbPlan.Checked && !rdbTodo.Checked)
            {
                MessageBox.Show("Seleccione un criterio de búsqueda", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (rdbCodigo.Checked)
            {
                for (int i = 0; i < arrListado.GetLength(0); i++)
                {
                    AgregarMateria(i);
                }
            }
            if (rdbTodo.Checked)
            {
                for (int i = 0; i < arrListado.GetLength(0); i++)
                {
                    AgregarMateria(i);
                }

            }
            if (rdbCodigo.Checked)
            {
                for (int i = 0; i < arrListado.GetLength(0); i++)
                {
                    AgregarMateria(i);
                }

            }

            if (rdbPlan.Checked)
            {
                for (int i = 0; i < arrListado.GetLength(0); i++)
                {
                    AgregarMateria(i);
                }
            }
            if (rdbNombre.Checked)
            {
                for (int i = 0; i < arrListado.GetLength(0); i++)
                {
                    AgregarMateria(i);
                }
            }
        }

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void AgregarMateria(int indice)
        {
            if (!string.IsNullOrWhiteSpace(arrListado[indice, 0]))
            {
                dgvListado.Rows.Add(arrListado[indice, 0], arrListado[indice, 1], arrListado[indice, 2]);
            }
        } 
    }
}
