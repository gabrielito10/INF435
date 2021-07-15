using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//ensamblado para Slq Server
using System.Data.SqlClient;

namespace _11ProcedimientosAlmacenados
{
    public partial class Form1 : Form
    {
        //conexion con SQL Server
        SqlConnection conex = new SqlConnection("Server=PC;Initial Catalog=VENTAS;Integrated Security=true");
        String BANDERA = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand();
            com.Connection = conex;
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "sp_BusquedaPorCi";
            com.Parameters.Add(new SqlParameter("@CI", txtCi.Text));
            //Recibiendo los datos
            DataSet ds = new DataSet(); //objeto que permite recibir tablas - array
            //adaptando el comando de sql server
            SqlDataAdapter da = new SqlDataAdapter(com);
            //descargo los datos del adaptador al dataset
            da.Fill(ds);


            txtNombre.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
            txtDireccion.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
            txtCelular.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BANDERA = "MODIFICAR";
            EjecutarProcedimiento();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BANDERA = "ELIMINAR";
            EjecutarProcedimiento();
        }
        private void EjecutarProcedimiento()
        {
            try
            {
                SqlCommand com = new SqlCommand();
                com.Connection = conex;
                com.CommandType = CommandType.StoredProcedure;
                com.CommandText = "sp_Cliente";
                com.Parameters.Add(new SqlParameter("@_CI", txtCi.Text));
                com.Parameters.Add(new SqlParameter("@_NOMBRE", txtNombre.Text));
                com.Parameters.Add(new SqlParameter("@_DIRECCION", txtDireccion.Text));
                com.Parameters.Add(new SqlParameter("@_CELULAR", txtCelular.Text));

                if (BANDERA == "MODIFICAR")
                {
                    com.Parameters.Add(new SqlParameter("@_ACCION", "MODIFICAR"));
                }
                if (BANDERA == "ELIMINAR")
                {
                    com.Parameters.Add(new SqlParameter("@_ACCION", "ELIMINAR"));
                }
                //ABRIENDO CONEXION
                conex.Open();
                com.ExecuteNonQuery();
                conex.Close();
            }
            catch (Exception ERR)
            {
                MessageBox.Show(ERR.Message);
            }
        }

    }
}
