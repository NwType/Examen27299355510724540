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
    public class ClienteBss
    {
        ClienteDal dal = new ClienteDal();
        public DataTable ListarClienteBss()
        {
            return dal.ListarClienetesDal();
        }
        public DataTable ListarClienteIngresoBss()
        {
            return dal.ListarClienetesIngresoDal();
        }
        public DataTable ListarClienteMontoBss()
        {
            return dal.ListarClienetesMontoDal();
        }
        public void InsertarClienteBss(Cliente cliente)
        {
            dal.InserarClienteDal(cliente);
        }
    }
}
