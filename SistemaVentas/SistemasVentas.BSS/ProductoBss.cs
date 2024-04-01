using SistemasVentas.DAL;
using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.BSS
{
    public class ProductoBss
    {
        ProductoDal dal = new ProductoDal();
        public DataTable ListarProductoBss()
        {
            return dal.ListarProductoDal();
        }
        public DataTable ListarProductoVencimientoBss()
        {
            return dal.ListarProductoVencimientoDal();
        }
        public DataTable ListarProductoVentaBss()
        {
            return dal.ListarProductoPorVentaDal();
        }
        public void InsertarProductoBss(Producto p)
        {
            dal.InsertarProductoDal(p);
        }
        public Producto ObtenerIdBss(int id)
        {
            return dal.ObtenerProductoId(id);
        }
        public void EditarProductoBss(Producto p)
        {
            dal.EditarProductoDaL(p);
        }
        public void EliminarPersonaBss(int id)
        {
            dal.EliminarProductoDal(id);
        }
    }
}
