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
    public class PersonaBss
    {
        PersonaDal dal = new PersonaDal();
        public DataTable ListarPersonaBss()
        {
            return dal.ListarPersonasDal();
        }
        public void InserarPersonaBss(Persona persona)
        {
             dal.InserarPersonaDal(persona);
        }
        public Persona ObtenerIdBss(int id)
        {
            return dal.ObtenerPersonaId(id);
        }
        public void  EditarPersonaBss(Persona p)
        {
             dal.EditarPersonaDaL(p);
        }
        public void EliminarPersonaBss(int id)
        {
            dal.EliminarPersonaDal(id);
        }

    }
}
