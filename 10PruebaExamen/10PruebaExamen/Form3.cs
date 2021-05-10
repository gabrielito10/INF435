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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(lstUno.SelectedItem.ToString());
            int num2 = int.Parse(lstDos.SelectedItem.ToString());
            int res = num1 + num2;
            MessageBox.Show(res.ToString());
        }
    }
}
