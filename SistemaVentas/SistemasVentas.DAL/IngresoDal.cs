using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class IngresoDal
    {
        public DataTable ListarIngresoDal()
        {
            string consulta = "select * from ingreso";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
        public void InsertarIngresoDal(Ingresocs ingreso)
        {
            string fechaFormateada = ingreso.FechaIngreso.ToString("yyyy-MM-dd HH:mm:ss");
            string consulta = "INSERT INTO Ingreso VALUES (" + ingreso.Proveedor + ", '" + fechaFormateada + "', " + ingreso.Total + ", 'Activo')";
            conexion.Ejecutar(consulta);
        }
    }
}
