using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _10BaseDeDatos
{
    public partial class Form1 : Form
    {
        static string bandera = "";     
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Creacndo variable para conectar la clase
            BaseDeDatos x = new BaseDeDatos();

            //Creando un comando entre sql y c#
            SqlCommand com = new SqlCommand();
            com.Connection = x.conex;
            com.CommandText = "sp_BusquedaCliente";
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add(new SqlParameter("@CI", txtBuscar.Text));

            //Creando un adaptador
            SqlDataAdapter da = new SqlDataAdapter(com);

            // Bajando el adaptador a un dataset
            DataSet ds = new DataSet();
            da.Fill(ds);

            //Llenando Datos
            txtCi.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            txtNombre.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
            txtCelular.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
            cmbDepartamento.SelectedItem = ds.Tables[0].Rows[0].ItemArray[3].ToString();
        }

        private void brnInsertar_Click(object sender, EventArgs e)
        {
            txtCi.Text = "";
            txtNombre.Text = "";
            txtCelular.Text = "";
            txtCi.Enabled = true;
            txtNombre.Enabled = true;
            txtCelular.Enabled = true;
            cmbDepartamento.Enabled = true;
            txtCi.Focus();
            bandera = "INSERTAR";
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            txtNombre.Enabled = true;
            txtCelular.Enabled = true;
            cmbDepartamento.Enabled = true;
            txtCi.Focus();
            bandera = "MODIFICAR";
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            BaseDeDatos x = new BaseDeDatos();
            //Creando un comando entre sql y c#
            SqlCommand com = new SqlCommand();
            com.Connection = x.conex;
            com.CommandText = "sp_RegistroCliente";
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add(new SqlParameter("@CI", txtCi.Text));
            com.Parameters.Add(new SqlParameter("@Nombre", txtNombre.Text));
            com.Parameters.Add(new SqlParameter("@Celular", txtCelular.Text));
            com.Parameters.Add(new SqlParameter("@Nacimiento", cmbDepartamento.SelectedItem));
            if (bandera == "INSERTAR")
                com.Parameters.Add(new SqlParameter("@Accion", "INSERTAR"));
            else
                com.Parameters.Add(new SqlParameter("@Accion", "ACTUALIZAR"));
            //EJECUTANDO EL COMANDO
            x.conex.Open();
            com.ExecuteNonQuery();
            x.conex.Close();
            //BLOQUEANDO CONTROLES

            txtCi.Enabled = false;
            txtNombre.Enabled = false;
            txtCelular.Enabled = false;
            cmbDepartamento.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            BaseDeDatos x = new BaseDeDatos();
            //Creando un comando entre sql y c#
            SqlCommand com = new SqlCommand();
            com.Connection = x.conex;
            com.CommandText = "sp_RegistroCliente";
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add(new SqlParameter("@CI", txtCi.Text));
            com.Parameters.Add(new SqlParameter("@Nombre", txtNombre.Text));
            com.Parameters.Add(new SqlParameter("@Celular", txtCelular.Text));
            com.Parameters.Add(new SqlParameter("@Nacimiento", cmbDepartamento.SelectedItem));
            com.Parameters.Add(new SqlParameter("@Accion", "ELIMINAR"));
            //EJECUTANDO EL COMANDO
            x.conex.Open();
            com.ExecuteNonQuery();
            x.conex.Close();
        }
    }
}
