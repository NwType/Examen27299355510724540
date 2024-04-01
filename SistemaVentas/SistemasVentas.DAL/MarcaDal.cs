using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class MarcaDal
    {
        public DataTable ListarMarcaDal()
        {
            string consulta = "SELECT TOP 1 M.Nombre AS NombreMarca, COUNT(*) AS TotalVentas " +
                  "FROM DetalleVenta DV " +
                  "INNER JOIN Producto P ON DV.IdProducto = P.IdProducto " +
                  "INNER JOIN Marca M ON P.IdMarca = M.IdMarca " +
                  "GROUP BY M.Nombre " +
                  "ORDER BY COUNT(*) DESC ";

            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
        public void InsertarMarcaDal(Marca m)
        {
            string consulta = "insert into marca values('" + m.Nombre + "'," + "'Inactivo')";
            conexion.Ejecutar(consulta);
        }
        public Marca ObtenerMarcaId(int id)
        {
            string consulta = "select * from marca where idmarca=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "ya");
            Marca m=new Marca();
            if (tabla.Rows.Count > 0)
            {
                m.IdMarca = Convert.ToInt32(tabla.Rows[0]["idmarca"]);
                m.Nombre = tabla.Rows[0]["nombre"].ToString();
            }
            return m;
        }
        public void EditarMarcaDal(Marca m)
        {
            string consulta = "UPDATE marca SET nombre = '" + m.Nombre + "' WHERE idMarca = " + m.IdMarca;

            conexion.Ejecutar(consulta);
        }
        public void EliminarMarcaDal(int id)
        {
            string consulta = "DELETE FROM marca WHERE idmarca = " + id;

            conexion.Ejecutar(consulta);
        }
    }
}
