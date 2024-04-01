using System.Data;
using SistemaVentas.Modelos;
using SistemasVentas.DAL;
namespace SistemasVentas.DAL
{
    public class RolDal
    {
        public DataTable ListarRolDal()
        {
            string consulta = "select * from rol";
            DataTable listar = conexion.EjecutarDataTabla(consulta, "listar");
            return listar;
        }
        public void InsertarRolDal(Rol rol)
        {
            string consulta = "insert into rol values('" + rol.Nombre + "'," + "'Activo')";
            conexion.Ejecutar(consulta);
        }
    }
}
