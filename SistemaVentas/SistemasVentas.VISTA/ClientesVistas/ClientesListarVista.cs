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
    public partial class ClientesListarVista : Form
    {
        public ClientesListarVista()
        {
            InitializeComponent();
        }
        ClienteBss Bss= new ClienteBss();
        private void ClientesListarVista_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Bss.ListarClienteBss();
        }
    }
}
