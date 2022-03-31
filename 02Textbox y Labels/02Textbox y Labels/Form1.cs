using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02Textbox_y_Labels
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string resultado = "";
            // Conversion de datos
            int N = int.Parse(txtValorN.Text);
            // 0, 1, 1, 2, 3, 5, 6......N
            int a = 0;
            resultado = resultado + a + " ";
            int b = 1;
            resultado = resultado + b + " ";
            for (int i=2 ; i<N ; i++)
            {
                int suma = a + b;
                resultado = resultado + suma + " ";
                a = b;
                b = suma;
            }
            lblResultado.Text = "La serie es: " + resultado;
        }
    }
}
