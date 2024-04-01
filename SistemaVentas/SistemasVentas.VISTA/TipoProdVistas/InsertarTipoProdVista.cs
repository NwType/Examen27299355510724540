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

namespace SistemasVentas.VISTA.TipoProdVistas
{
    public partial class InsertarTipoProdVista : Form
    {
        public InsertarTipoProdVista()
        {
            InitializeComponent();
        }
        TipoProdBss bss = new TipoProdBss();
        private void button1_Click(object sender, EventArgs e)
        {
            TIPOPROD tp = new TIPOPROD();
            tp.nombre = textBox1.Text;
            bss.InsertarTipoProdBss(tp);
            MessageBox.Show("Se guardo correctamente");
        }
    }
}
