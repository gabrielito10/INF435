using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03RadioButton_y_CheckBox
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
            {
                MessageBox.Show("Ud. es soltero");
            }
            if (rbtCasado.Checked == true)
            {
                MessageBox.Show("Ud. es Casado");
            }
            if (rbtDivorciado.Checked == true)
            {
                MessageBox.Show("Ud. es Divorciado");
            }
            if (rbtViudo.Checked)
            {
                MessageBox.Show("Ud. es Viudo");
            }
        }

        private void btnDeporte_Click(object sender, EventArgs e)
        {
            if (chkFutbol.Checked == false && 
                chkBasquet.Checked == false &&
                chkVolibol.Checked == false &&
                chkRaquet.Checked == false)
            {
                //Ninguno fue seleccionado
                MessageBox.Show("A ud. no le gusta nada");
            }
            else
            {
                //Al menos uno fue seleccionado
                string mensaje = "A ud le gusta el ";
                if (chkFutbol.Checked == true)
                {
                    mensaje = mensaje + chkFutbol.Text + " ";
                }
                if (chkBasquet.Checked == true)
                {
                    mensaje += "Basquet ";
                }
                if (chkVolibol.Checked)
                {
                    mensaje += "Volibol ";
                }
                if (chkRaquet.Checked)
                {
                    mensaje += "Raquet";
                }
                MessageBox.Show(mensaje);
            }
        }
    }
}
