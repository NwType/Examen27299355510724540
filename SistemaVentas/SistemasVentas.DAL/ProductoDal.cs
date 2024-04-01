using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class ProductoDal
    {
          public DataTable ListarProductoDal()
        {
            string consulta = "SELECT SUM(unidad) AS CantidadTotalProductos FROM Producto";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
        public DataTable ListarProductoVencimientoDal()
        {
            string consulta = @"SELECT P.NOMBRE AS NombreProducto, d.FECHAVENC
                       FROM DETALLEING D
                       INNER JOIN PRODUCTO P ON D.IDPRODUCTO = P.IDPRODUCTO
                       WHERE YEAR(D.FECHAVENC) = 2024
                       AND DATEDIFF(day, GETDATE(), D.FECHAVENC) <= 7;";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
        public DataTable ListarProductoPorVentaDal()
        {
            string consulta = @"SELECT TP.NOMBRE AS TipoProducto, COUNT(DV.IDPRODUCTO) AS CantidadVendida
                        FROM DETALLEVENTA DV
                        INNER JOIN PRODUCTO P ON DV.IDPRODUCTO = P.IDPRODUCTO
                        INNER JOIN TIPOPROD TP ON P.IDTIPOPROD = TP.IDTIPOPROD
                        GROUP BY TP.NOMBRE";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
        
        public void InsertarProductoDal(Producto p)
        {
            string consulta = "INSERT INTO producto values (" + p.IdTipoProd + ", " + p.IdMarca + ", '" + p.Nombre + "', '" + p.CodigoBarra + "', " + p.Unidad + ", '" + p.Descripcion + "', 'Activo')";
            conexion.Ejecutar(consulta);
        }
        public Producto ObtenerProductoId(int id)
        {
            string consulta = "select * from producto where idproducto=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "ya");
            Producto p = new Producto();
            if (tabla.Rows.Count > 0)
            {
                p.IdProducto = Convert.ToInt32(tabla.Rows[0]["idproducto"]);
                p.IdTipoProd = Convert.ToInt32( tabla.Rows[0]["idtipoprod"]);
                p.IdMarca = Convert.ToInt32(tabla.Rows[0]["idmarca"]);
                p.Nombre = tabla.Rows[0]["nombre"].ToString();
                p.CodigoBarra = tabla.Rows[0]["codigobarra"].ToString();
                p.Unidad = Convert.ToInt32(tabla.Rows[0]["unidad"]);
                p.Descripcion = tabla.Rows[0]["descripcion"].ToString();
            }
            return p;
        }
        public void EditarProductoDaL(Producto p)
        {
            string consulta = "update marca set idproducto='" + p.IdProducto + "', " + "idtipoprod='" +
            p.IdTipoProd + "', " + "marca='" + p.IdMarca + "', " + "nombre='" + p.Nombre + "', " +
            "correo='" + p.CodigoBarra + "', " + "'" + p.Unidad + "', '" + p.Descripcion + "' " +
            "where idproducto=" + p.IdProducto;
            conexion.Ejecutar(consulta);


        }
        public void EliminarProductoDal(int id)
        {
            string consulta = "delete from persona where idproducto=" + id;
            conexion.Ejecutar(consulta);
        }

    }

}
