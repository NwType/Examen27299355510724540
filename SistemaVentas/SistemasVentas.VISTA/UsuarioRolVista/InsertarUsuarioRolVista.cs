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

namespace SistemasVentas.VISTA.UsuarioRolVista
{
    public partial class InsertarUsuarioRolVista : Form
    {
        public InsertarUsuarioRolVista()
        {
            InitializeComponent();
        }
        UsuarioRolBss bss = new UsuarioRolBss();
        private void button1_Click(object sender, EventArgs e)
        {
            UsuarioRol UR = new UsuarioRol();
            UR.IdUsuario=Convert.ToInt32(textBox1.Text);
            UR.IdRol=Convert.ToInt32(textBox2.Text);
            UR.FechaSigna=Convert.ToDateTime(textBox3.Text);
            bss.InsertarUsuarioRolBss(UR);
            MessageBox.Show("Se guardo correctamente");
        }
    }
}
