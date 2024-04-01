using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.Modelos
{
    public class Ingresocs
    {
        public int IdIngreso { get; set; }
        public int Proveedor { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int Total {  get; set; }
        public string Estado { get; set; }
    }
}
