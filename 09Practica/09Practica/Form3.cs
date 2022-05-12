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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int resultado = 0;
            int a = int.Parse(lstUno.SelectedItem.ToString());
            int b = int.Parse(lstDos.SelectedItem.ToString());
            resultado = a + b;
            MessageBox.Show(resultado.ToString());
        }
    }
}
