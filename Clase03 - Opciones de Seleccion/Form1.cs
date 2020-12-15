using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase03___Opciones_de_Seleccion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            float a = float.Parse(txtNum1.Text);
            float b = float.Parse(txtNum2.Text);
            float resultado = 0;
            // para verificar si una opcion a sido seleccionada
            //utilizamos la propiedad "Checked" -> true - false
            if (opSuma.Checked == true) // que a sido seleccionado
                resultado = a + b;
            if (opResta.Checked == true)
                resultado = a - b;
            if (opMultiplicacion.Checked == true)
                resultado = a * b;
            if (opDivision.Checked == true)
                resultado = a / b;
            MessageBox.Show(resultado.ToString());
        }

        private void btnMostrarColores_Click(object sender, EventArgs e)
        {
            // para verificar si una opcion a sido seleccionada
            //utilizamos la propiedad "Checked" -> true - false
            if (opRojo.Checked == false && opAmarillo.Checked==false &&
                opVerde.Checked==false && opAzul.Checked==false)
            {
                MessageBox.Show("A ud. no le gusta ningun color");
            }
            else
            {
                string cadena = "A ud. le gusta el color: ";
                if (opRojo.Checked == true)
                    cadena = cadena +  opRojo.Text + " ";
                if (opAmarillo.Checked == true)
                    cadena = cadena + opAmarillo.Text + " ";
                if (opVerde.Checked == true)
                    cadena = cadena + opVerde.Text + " ";
                if (opAzul.Checked == true)
                    cadena = cadena + opAzul.Text;
                MessageBox.Show(cadena);

            }
        }
    }
}
