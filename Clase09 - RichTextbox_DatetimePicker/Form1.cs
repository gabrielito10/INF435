using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase09___RichTextbox_DatetimePicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToString()) ;
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            //cambiando caracteres desde una posicion y una longitud
            txtTexto.Select(4, 6);
            txtTexto.SelectionColor = Color.Green;
            txtTexto.SelectionFont = new Font("MS Gothic", 24, FontStyle.Underline);
            txtTexto.SelectionBackColor = Color.Aquamarine;
            //cambiar todo una linea
            int numDeLinea = 1;
            int inicio = txtTexto.GetFirstCharIndexFromLine(numDeLinea);
            int longitud = txtTexto.Lines[numDeLinea].Length;
            txtTexto.Select(inicio, longitud);
            txtTexto.SelectionColor = Color.DarkBlue;
            txtTexto.SelectionFont = new Font("Arial", 16, FontStyle.Bold);
            txtTexto.SelectionBackColor = Color.Yellow;
        }
    }
}
