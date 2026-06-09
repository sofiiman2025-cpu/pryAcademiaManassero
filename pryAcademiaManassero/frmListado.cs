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
        public string[,] arrListado = new string[4, 5]; // will be assigned from frmRegistro
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
    }
}
