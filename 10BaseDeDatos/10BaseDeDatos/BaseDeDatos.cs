using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Añadiendo Librerias para Conexion a Sql Server
using System.Data;
using System.Data.SqlClient;

namespace _10BaseDeDatos
{
    class BaseDeDatos
    {
        //Creando la conexion a Sql Server
        static string texto = "Server=(local);" +
            "Initial Catalog=BD_VENTAS;" +
            "Integrated Security=true";
        public SqlConnection conex = new SqlConnection(texto);
    }
}
