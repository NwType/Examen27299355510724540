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

namespace SistemasVentas.VISTA.ProveedorVistas
{
    public partial class consulta8 : Form
    {
        public consulta8()
        {
            InitializeComponent();
        }
        ProveedorBss bss = new ProveedorBss();
        private void consulta8_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarProveedorIngresoBss();
        }
    }
}
