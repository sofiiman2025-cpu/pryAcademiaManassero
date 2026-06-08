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
        public string[,] arrListado; // will be assigned from frmRegistro
        public frmListado()
        {
            InitializeComponent();
        }

        private void frmListado_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvListado.Rows.Clear();

            if (arrListado == null)
            {
                MessageBox.Show("No hay datos para mostrar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            for (int i = 0; i < arrListado.GetLength(0); i++)
            {
                if (!string.IsNullOrWhiteSpace(arrListado[i, 0]))
                {
                    // Expecting: 0=Codigo, 1=Nombre, 2=Plan, 3=Estado
                    dgvListado.Rows.Add(arrListado[i, 0], arrListado[i, 1],
                        arrListado[i, 2], arrListado[i, 3]);
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
    }
}
