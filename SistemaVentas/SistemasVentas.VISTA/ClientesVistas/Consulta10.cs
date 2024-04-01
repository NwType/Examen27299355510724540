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
    public partial class Consulta10 : Form
    {
        public Consulta10()
        {
            InitializeComponent();
        }
        ClienteBss bss=new ClienteBss();
        private void Consulta10_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bss.ListarClienteMontoBss();
        }
    }
}
