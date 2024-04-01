using System.Data;

namespace SistemasVentas.DAL
{
    public class Class1
    {
        public DataTable ListarUsuarioDal()
        {
            string consulta = "select * from usuario";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
    }
}
