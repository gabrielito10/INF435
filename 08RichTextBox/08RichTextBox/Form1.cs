using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08RichTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            txtLetras.Select(5, 15);
            txtLetras.SelectionBackColor = Color.Red;
            txtLetras.SelectionFont = new Font("Impact",20,FontStyle.Bold);
            txtLetras.SelectionColor = Color.White;

            //seleecionando una linea
            int numLinea = 1;
            int inicio = txtLetras.GetFirstCharIndexFromLine(numLinea);
            int longitud = txtLetras.Lines[numLinea].Length;
            txtLetras.Select(inicio, longitud);
            txtLetras.SelectionColor=Color.Green;
        }
    }
}
