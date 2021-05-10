using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10PruebaExamen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int N = int.Parse(txtN.Text);
            int serie = 1;
            string salida1 = serie.ToString();
            string salida2 = "1";
            for (int i=1 ; i<=N ; i++)
            {
                if (i % 2 != 0) // es impar
                {
                    serie = serie + 2;
                }
                else // es par
                {
                    serie *= 2;
                }
                salida2 = salida2 + "," + serie.ToString();
                // 1 , 3 , 6 , 8
             }
            MessageBox.Show(salida2);
        }
    }
}
