using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09Practica
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtNum1.Text);
            int b = int.Parse(txtNum2.Text);
            int resultado = 0;
            if (rbtSuma.Checked)
                resultado = a + b;
            if (rbtResta.Checked)
                resultado = a - b;
            MessageBox.Show("El resultado es: " + resultado);
        }
    }
}
