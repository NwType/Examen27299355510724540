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

namespace SistemasVentas.VISTA.ProveedorVistas
{
    public partial class EditarProveedor : Form
    {
        int idx = 0;
        Proveedor p = new Proveedor();
        ProveedorBss bss=new ProveedorBss();
        public EditarProveedor(int id)
        {
            InitializeComponent();
            idx = id;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            p.nombre = textBox1.Text;
            p.direccion = textBox3.Text;
            p.telefono = textBox2.Text;
            bss.EditarProveedorBss(p);
            MessageBox.Show("datos actualizados");
        }

        private void EditarProveedor_Load(object sender, EventArgs e)
        {
            p = bss.ObtenerProveedorIdBss(idx);
            textBox1.Text = p.nombre;
            textBox2.Text = p.telefono;
            textBox3.Text = p.direccion;
        }
    }
}
