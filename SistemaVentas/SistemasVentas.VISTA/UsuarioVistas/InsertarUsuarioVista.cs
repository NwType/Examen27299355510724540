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

namespace SistemasVentas.VISTA.UsuarioVistas
{
    public partial class InsertarUsuarioVista : Form
    {
        public InsertarUsuarioVista()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        UsuarioBss bss = new UsuarioBss();
        private void button1_Click(object sender, EventArgs e)
        {
            Usuario u = new Usuario();
            u.IdPersona = Convert.ToInt32(textBox1.Text);
            u.NombreUser = textBox2.Text;
            u.Contrasenia = textBox3.Text;
            u.FechaReg = dateTimePicker1.Value;
            bss.InsertarUsuarioBss(u);
            MessageBox.Show("Se guardo exitosamente");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
