using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SistemasVentas.DAL
{
    public class DetalleVentaDal
    {
        public DataTable ListarDetalleVentaDal()
        {
            string consulta = "select * from detalleventa";
            DataTable lista = conexion.EjecutarDataTabla(consulta,"tabla");
            return lista;
            
        }
        public void InsertarDetalleVentaDal(DetalleVenta dv)
        {
            string consulta = "INSERT INTO detalleventa VALUES (" + dv.IdVenta + ", " + dv.IdProducto + ", " + dv.Cantidad + ", " + dv.PrecioVenta + ", " + dv.SubTotal + ",'Exitoso')";
            conexion.Ejecutar(consulta);
        }

    }
}
