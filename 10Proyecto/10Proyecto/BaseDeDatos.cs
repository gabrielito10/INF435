using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace _10Proyecto
{
    class BaseDeDatos
    {
        static string aux = "Server=(local);Initial Catalog=BD_VENTAS;Integrated Security=true";
        static SqlConnection conex = new SqlConnection(aux);

        public DataSet SeleccionTabla(string nomTabla)
        {
            SqlCommand com = new SqlCommand();
            com.Connection = conex;
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "sp_Reportes";
            com.Parameters.Add(new SqlParameter("@TipoReporte", nomTabla));
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public void RegistroCliente(string Ci, string Nombre,
            int Celular, string Estado_Civil, string Nacimiento,
            string Accion)
        {
            SqlCommand com = new SqlCommand();
            com.Connection = conex;
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "sp_Cliente";
            com.Parameters.Add(new SqlParameter("@CI", Ci));
            com.Parameters.Add(new SqlParameter("@NOMBRE", Nombre));
            com.Parameters.Add(new SqlParameter("@CELULAR", Celular));
            com.Parameters.Add(new SqlParameter("@ESTADO_CIVIL", Estado_Civil));
            com.Parameters.Add(new SqlParameter("@NACIMIENTO", Nacimiento));
            com.Parameters.Add(new SqlParameter("@ACCION", Accion));
            conex.Open();
            com.ExecuteNonQuery();
            conex.Close();
        }
    }
}
