using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03CheckBox_y_RadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            if (rbtSoltero.Checked == true)
                MessageBox.Show("Ud. es " +  rbtSoltero.Text);
            if (rbtCasado.Checked)
                MessageBox.Show("Ud. es " + rbtCasado.Text);
            if (rbtDivorciado.Checked)
                MessageBox.Show("Ud. es " + rbtDivorciado.Text);
            if (rbtViudo.Checked)
                MessageBox.Show("Ud. es " + rbtViudo.Text);
        }

        private void btnDeporte_Click(object sender, EventArgs e)
        {
            if (chbFutbol.Checked==false && chbBasquet.Checked==false
                && chbVolibol.Checked==false && chbAjedrez.Checked==false)
            {
                MessageBox.Show("A ud. no le gusta nada");
            }
            else
            {
                string texto = "A ud. le gusta ";
                if (chbFutbol.Checked)
                    texto = texto + chbFutbol.Text + " ";
                if (chbBasquet.Checked)
                    texto += chbBasquet.Text + " ";
                if (chbVolibol.Checked)
                    texto += chbVolibol.Text + " ";
                if (chbAjedrez.Checked)
                    texto += chbAjedrez.Text;
                MessageBox.Show(texto);
            }
        }
    }
}
