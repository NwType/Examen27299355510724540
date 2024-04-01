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

namespace SistemasVentas.VISTA.ProveedorVistas
{
    public partial class InsertarProveedorVista : Form
    {
        public InsertarProveedorVista()
        {
            InitializeComponent();
        }
        ProveedorBss bss = new ProveedorBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Proveedor p= new Proveedor();
            p.nombre=textBox1.Text;
            p.telefono = textBox2.Text;
            p.direccion=textBox3.Text;
            bss.InsertarProveedorBss(p);
            MessageBox.Show("Se guardo correctamente");

        }
    }
}
