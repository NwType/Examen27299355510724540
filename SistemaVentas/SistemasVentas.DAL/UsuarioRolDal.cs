using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class UsuarioRolDal
    {
        public DataTable ListarUsuarioRolDal()
        {
            string consulta = "select * from usuariorol";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
        public void InsertarUsuarioRolDal(UsuarioRol ur)
        {
            string fechaFormateada = ur.FechaSigna.ToString("yyyy-MM-dd HH:mm:ss");
            string consulta = "INSERT INTO usuariorol VALUES (" + ur.IdUsuario + "," + ur.IdRol + ",'" + fechaFormateada + "','Activo')";
            conexion.Ejecutar(consulta);
        }
    }
}
