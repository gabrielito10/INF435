using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02TextBox_y_Labels
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            // 1,3,6,8,16,18.......N
            //recUperar el valor de N

            //Conversion mediante el Convert
            int N1 = Convert.ToInt16(txtN.Text);

            //Conversion Implicita
            object x = 23;
            int N2 = (int)(x);

            //Conversion Explicita
            int N3 = int.Parse(txtN.Text);
            int serie = 1;
            string cadena = "1";
            for (int i=1 ; i<=N3; i++)
            {
                if (i % 2 != 0)
                    serie += 2;
                else
                    serie *= 2;
                cadena += " " + serie;
            }
            MessageBox.Show(cadena);
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Double Num1 = Convert.ToDouble(txtN1.Text.Replace(".",","));
            float Num2 = float.Parse(txtN2.Text.Replace(".",","));
            Double resultado = Num1 * Num2;
            MessageBox.Show(resultado.ToString());
        }
    }
}
