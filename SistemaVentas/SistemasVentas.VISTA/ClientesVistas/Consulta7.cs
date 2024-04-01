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

namespace SistemasVentas.VISTA.ClientesVistas
{
    public partial class Consulta7 : Form
    {
        public Consulta7()
        {
            InitializeComponent();
        }
        ClienteBss bss = new ClienteBss();
        private void Consulta7_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarClienteIngresoBss();
        }
    }
}
