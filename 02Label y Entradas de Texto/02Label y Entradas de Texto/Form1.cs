using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02Label_y_Entradas_de_Texto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            //excepcones
            try
            {
                float a = float.Parse(txtNum1.Text.Replace(".",","));
                float b = float.Parse(txtNum2.Text.Replace(".", ","));
                float res = a + b;
                MessageBox.Show(res.ToString());
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "INF435", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

