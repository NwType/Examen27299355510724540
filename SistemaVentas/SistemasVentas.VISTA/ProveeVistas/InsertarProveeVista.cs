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

namespace SistemasVentas.VISTA.ProveeVistas
{
    public partial class InsertarProveeVista : Form
    {
        public InsertarProveeVista()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        ProveeBss bss = new ProveeBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Provee p = new Provee();
            p.IdProducto = Convert.ToInt32(textBox1.Text);
            p.IdProveedor = Convert.ToInt32(textBox2.Text);
            p.Fecha=Convert.ToDateTime(textBox3.Text);
            p.Precio=Convert.ToDecimal(textBox4.Text);
            bss.InsertarProveeBss(p);
            MessageBox.Show("Se guardo correctamente");
        }
    }
}
