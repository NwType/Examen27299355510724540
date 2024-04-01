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

namespace SistemasVentas.VISTA.ProductoVistas
{
    public partial class Consulta5 : Form
    {
        public Consulta5()
        {
            InitializeComponent();
        }
        ProductoBss bss = new ProductoBss();
        private void Consulta5_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarProductoVencimientoBss();
        }
    }
}
