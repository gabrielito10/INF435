using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07Practica
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int suma = 0;
            if (op1.Checked == false && op2.Checked == false
                && op3.Checked == false)
            {
                MessageBox.Show("La suma es: " + suma.ToString());
            }
            {
                if (op1.Checked)
                    suma +=  int.Parse(op1.Text);
                if (op2.Checked)
                    suma +=  int.Parse(op2.Text);
                if (op3.Checked)
                    suma +=  int.Parse(op3.Text);
                MessageBox.Show("La suma es: " + suma.ToString());
            }
        }
    }
}
