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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            float a = float.Parse(txtNum1.Text);
            float b = float.Parse(txtNum2.Text);
            float res = 0;
            if (opSuma.Checked == true)
                res = a + b;
            if (opResta.Checked)
                res = a - b;
            if (opMultiplicacion.Checked)
                res = a * b;
            if (opDivision.Checked)
                res = a / b;
            MessageBox.Show(res.ToString());
        }
    }
}
