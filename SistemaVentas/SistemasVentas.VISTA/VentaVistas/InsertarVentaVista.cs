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

namespace SistemasVentas.VISTA.VentaVistas
{
    public partial class InsertarVentaVista : Form
    {
        public InsertarVentaVista()
        {
            InitializeComponent();
        }
        VentaBss bss=new VentaBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Venta v=new Venta();
            v.IdCliente=Convert.ToInt32(textBox1.Text);
            v.IdVendedor=Convert.ToInt32(textBox2.Text);
            v.Fecha=Convert.ToDateTime(textBox3.Text);
            v.Total=Convert.ToInt32(textBox4.Text);
            bss.InsertarVentaBss(v);
            MessageBox.Show("la venta se guardo correctamente");
        }
    }
}
