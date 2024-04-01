using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class UsuarioDal
    {
        public DataTable ListarUsuarioDal()
        {
            string consulta = "select * from usuario";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
        public void InsertarUsuarioDal(Usuario u)
        {
                string fechaFormateada = u.FechaReg.ToString("yyyy-MM-dd HH:mm:ss"); 

                string consulta = "INSERT INTO usuario VALUES (" + u.IdPersona + ", '" + u.NombreUser + "', '" + u.Contrasenia + "', '" + u.FechaReg + "')";
                conexion.Ejecutar(consulta);
        }
        
    }
}
