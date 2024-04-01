using SistemasVentas.BSS;
using SistemaVentas.Modelos;
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
    public partial class InsertarDetalleVentaVista : Form
    {
        public InsertarDetalleVentaVista()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        DetalleVentaBss bss= new DetalleVentaBss();
        private void button1_Click(object sender, EventArgs e)
        {
            DetalleVenta dv= new DetalleVenta();
            dv.IdVenta = Convert.ToInt32(textBox1.Text);
            dv.IdProducto = Convert.ToInt32(textBox2.Text);
            dv.Cantidad= Convert.ToInt32(textBox3.Text);
            dv.PrecioVenta=Convert.ToDecimal(textBox4.Text);
            dv.SubTotal = Convert.ToDecimal(textBox5.Text);
            bss.InsertarDetalleVentaBss(dv);
            MessageBox.Show("Se guardo correctamente el detalle de venta");
        }
    }
}
