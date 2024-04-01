using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class TipoProdDal
    {
        public DataTable ListarTipoProdDal()
        {
            string consulta = "select * from tipoprod";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }
        public void InsertarTipoProdDal(TIPOPROD tp)
        {
            string consulta = "insert into tipoprod values('" + tp.nombre + "'," + "'Inactivo')";
            conexion.Ejecutar(consulta);
        }
    }
}
