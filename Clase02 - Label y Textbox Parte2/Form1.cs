using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase02___Label_y_Textbox_Parte2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            float resultado;
            // conversion de datos 
            //funcionamiento del replace
            //replace("ValorReemplazado","NuevoValor")
            //replace("Juan","Pepito")
            resultado = float.Parse(txtNum1.Text.Replace(".", ",")) +
                float.Parse(txtNum2.Text.Replace(".", ","));
            MessageBox.Show(resultado.ToString());
        }
    }
}
