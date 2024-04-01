using SistemasVentas.BSS;
using SistemasVentas.VISTA.MarcaVistas;
using SistemasVentas.VISTA.ProveedorVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.AdministradorAlmacenVista
{
    public partial class ProveedorVista : Form
    {
        public ProveedorVista()
        {
            InitializeComponent();
        }
        ProveedorBss bss = new ProveedorBss();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ProveedorVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarProveedorBss();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            InsertarProveedorVista fr = new InsertarProveedorVista();
            fr.ShowDialog();
            {
                dataGridView1.DataSource = bss.ListarProveedorBss();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int IdProveedorSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            EditarProveedor fr = new EditarProveedor(IdProveedorSeleccionada);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarProveedorBss();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int IdMarcaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("esta seguro de eliminar este proveedor", "eliminando", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarProveedorBss(IdMarcaSeleccionada);
                dataGridView1.DataSource = bss.ListarProveedorBss();
            }
        }
    }
}
