using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class ClienteDal
    {
        public DataTable ListarClienetesDal()
        {
            string consulta = @"SELECT PERSONA.NOMBRE, PERSONA.APELLIDO
                            FROM CLIENTE
                            INNER JOIN PERSONA ON CLIENTE.IDPERSONA = PERSONA.IDPERSONA";

            DataTable resultado = conexion.EjecutarDataTabla(consulta, "clientes");
            return resultado;
        }
        string consulta = @"SELECT C.IDCLIENTE, P.NOMBRE + ' ' + P.APELLIDO AS NombreCliente, SUM(V.TOTAL) AS TotalIngresos
                        FROM CLIENTE C
                        INNER JOIN PERSONA P ON C.IDPERSONA = P.IDPERSONA
                        INNER JOIN VENTA V ON C.IDCLIENTE = V.IDCLIENTE
                        GROUP BY C.IDCLIENTE, P.NOMBRE, P.APELLIDO";
        public DataTable ListarClienetesIngresoDal()
        {
            string consulta = @"SELECT P.NOMBRE + ' ' + P.APELLIDO AS NombreCliente, SUM(V.TOTAL) AS TotalIngresos
                        FROM CLIENTE C
                        INNER JOIN PERSONA P ON C.IDPERSONA = P.IDPERSONA
                        INNER JOIN VENTA V ON C.IDCLIENTE = V.IDCLIENTE
                        GROUP BY C.IDCLIENTE, P.NOMBRE, P.APELLIDO";

            DataTable resultado = conexion.EjecutarDataTabla(consulta, "clientes");
            return resultado;
        }
        
        public DataTable ListarClienetesMontoDal()
        {
            string consulta = @"SELECT P.NOMBRE AS NombreCliente, SUM(V.TOTAL) AS TotalCompras
                        FROM CLIENTE C
                        INNER JOIN VENTA V ON C.IDCLIENTE = V.IDCLIENTE
                        INNER JOIN PERSONA P ON C.IDCLIENTE = P.IDPERSONA
                        GROUP BY P.NOMBRE
                        HAVING SUM(V.TOTAL) >100";

            DataTable resultado = conexion.EjecutarDataTabla(consulta, "clientes");
            return resultado;
        }
        public void InserarClienteDal(Cliente c)
        {
            string consulta = "insert into cliente values ("+ c.IdPersona + ",'" +
                c.TipoCliente + "','" + c.CodigoCliente + "','Activos')";
            conexion.Ejecutar(consulta);
        }


    }
}
