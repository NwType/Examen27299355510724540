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

namespace SistemasVentas.VISTA.DetalleVentaVistas
{
    public partial class DetalleVentaListarVenta : Form
    {
        public DetalleVentaListarVenta()
        {
            InitializeComponent();
        }
        DetalleVentaBss bss = new DetalleVentaBss();
        private void DetalleVentaListarVenta_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarDetalleVentaBss();
        }
    }
}
