using SistemasVentas.BSS;
using SistemasVentas.VISTA.PersonaVistas;
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
    public partial class UsuarioInsertarVistasP : Form
    {
        public UsuarioInsertarVistasP()
        {
            InitializeComponent();
        }
        public static int IdPersonaSeleccionada = 0;
        PersonaBss bss = new PersonaBss();
        public void button1_Click(object sender, EventArgs e)
        {
            PersonaListarVista fr = new PersonaListarVista();
            if (fr.ShowDialog() == DialogResult.OK)
            {
                Persona persona = bss.ObtenerIdBss(IdPersonaSeleccionada);
                textBox1.Text = persona.Nombre + " " + persona.Apellido;
            }
        }

        UsuarioBss bssuser = new UsuarioBss();
        public void button2_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.IdPersona = IdPersonaSeleccionada;
            usuario.NombreUser = textBox2.Text;
            usuario.Contrasenia= textBox3.Text;
            usuario.FechaReg = dateTimePicker1.Value;
            bssuser.InsertarUsuarioBss(usuario);
            MessageBox.Show("Usuario registrado");
        }
    }
}
