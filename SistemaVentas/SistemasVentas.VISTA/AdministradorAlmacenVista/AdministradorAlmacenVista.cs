using SistemasVentas.BSS;
using SistemasVentas.VISTA.ProveedorVistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasVentas.VISTA.AdministradorAlmacenVista
{
    public partial class AdministradorAlmacenVista : Form
    {
        public AdministradorAlmacenVista()
        {
            InitializeComponent();
        }
        DetalleingBss bss= new DetalleingBss();
        private void button1_Click(object sender, EventArgs e)
        {
                dataGridView1.DataSource = bss.ListarDetalleingBss();
        }
    }
}
