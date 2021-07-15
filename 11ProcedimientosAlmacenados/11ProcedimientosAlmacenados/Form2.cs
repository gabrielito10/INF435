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

namespace _11ProcedimientosAlmacenados
{
    public partial class Form2 : Form
    {
        SqlConnection conex = new SqlConnection("Server=PC;Initial Catalog=VENTAS;Integrated Security=true");
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand com = new SqlCommand();
                com.Connection = conex;
                com.CommandType = CommandType.StoredProcedure;
                com.CommandText = "sp_Venta";
                com.Parameters.Add(new SqlParameter("@_CI", txtCi.Text));
                com.Parameters.Add(new SqlParameter("@_CODIGO", txtCodigo.Text));
                com.Parameters.Add(new SqlParameter("@_CANT_VENDIDA", txtCantidad.Text));

                conex.Open();
                com.ExecuteNonQuery();
                conex.Close();
            }
            catch(Exception ERROR)
            {
                MessageBox.Show(ERROR.Message);
            }
        }
    }
}
