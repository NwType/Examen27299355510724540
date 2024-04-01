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

namespace SistemasVentas.VISTA.IngresoVistas
{
    public partial class InsertarIngresoVista : Form
    {
        public InsertarIngresoVista()
        {
            InitializeComponent();
        }
        IngresoBss bss = new IngresoBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Ingresocs i= new Ingresocs();
            i.Proveedor = Convert.ToInt32(textBox1.Text);
            i.FechaIngreso=Convert.ToDateTime(textBox2.Text);
            i.Total=Convert.ToInt32(textBox3.Text);
            bss.InsertarIngresoBss(i);
            MessageBox.Show("Guardar datos");
        }
    }
}
