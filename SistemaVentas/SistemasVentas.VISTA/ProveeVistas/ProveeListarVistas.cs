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

namespace SistemasVentas.VISTA.ProveeVistas
{
    public partial class ProveeListarVistas : Form
    {
        public ProveeListarVistas()
        {
            InitializeComponent();
        }

        private void ProveeListarVistas_Load(object sender, EventArgs e)
        {
            ProveedorBss bss = new ProveedorBss();
            dataGridView1.DataSource = bss.ListarProveedorBss();
        }
    }
}
