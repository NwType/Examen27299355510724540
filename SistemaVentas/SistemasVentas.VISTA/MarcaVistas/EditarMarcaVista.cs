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

namespace SistemasVentas.VISTA.MarcaVistas
{
    public partial class EditarMarcaVista : Form
    {
        int idx = 0;
        Marca p = new Marca();
        MarcaBss bss = new MarcaBss();
        public EditarMarcaVista(int id)
        {
            idx = id;
            InitializeComponent();
        }

        private void EditarMarcaVista_Load(object sender, EventArgs e)
        {
            p = bss.ObtenerMarcaIdBss(idx);
            textBox1.Text = p.Nombre;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            p.Nombre= textBox1.Text;
            bss.EditarMarcaBss(p);
            MessageBox.Show("datos actualizados");
        }
    }
}
