using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class ProveeDal
    {
        public DataTable ListarProveeDal()
        {
            string consulta = "select * from provee";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
        public void InsertarProveeDal(Provee provee)
        {
            string fechaFormateada = provee.Fecha.ToString("yyyy-MM-dd HH:mm:ss");
            string consulta = "INSERT INTO Provee values (" + provee.IdProducto + ", " + provee.IdProveedor + ", '" + fechaFormateada + "', " + provee.Precio + ")";

            conexion.Ejecutar(consulta);
        }
    }
}
