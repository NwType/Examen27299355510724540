using SistemasVentas.BSS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.MarcaVistas
{
    public partial class MarcaListarVista : Form
    {
        public MarcaListarVista()
        {
            InitializeComponent();
        }
        MarcaBss bss = new MarcaBss();
        private void MarcaListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarMarcaBss();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertarMarcaVista fr = new InsertarMarcaVista();
            fr.ShowDialog();
            {
                dataGridView1.DataSource = bss.ListarMarcaBss();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int IdMarcaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            EditarMarcaVista fr = new EditarMarcaVista(IdMarcaSeleccionada);
            if (fr.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource = bss.ListarMarcaBss();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int IdMarcaSeleccionada = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("esta seguro de eliminar esta marca", "eliminando", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                bss.EliminarMarcaBss(IdMarcaSeleccionada);
                dataGridView1.DataSource = bss.ListarMarcaBss();
            }
        }
    }
}
