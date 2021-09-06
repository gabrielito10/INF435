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

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (opSoltero.Checked == true)
                MessageBox.Show("ud. es " + opSoltero.Text); //CORRECTO
            if (opCasado.Checked == true)
                MessageBox.Show("Ud. es " + opCasado.Text); //CORRECTO
            if (opDivorciado.Checked)
                MessageBox.Show("Ud. es divorciado"); // ESTO ESTA MAL
        }

        private void btnDeporte_Click(object sender, EventArgs e)
        {
            if (opFutbol.Checked == false && opBasquet.Checked== false &&
                opVoley.Checked==false)
            {
                //Que ninguno fue seleccionado
                MessageBox.Show("A ud. no le gusta nada");
            }
            else
            {
                string mensaje = "A ud. le gusta el ";
                if (opFutbol.Checked)
                    mensaje += opFutbol.Text; // CORRECTO
                if (opBasquet.Checked) 
                    mensaje += " Basquet";   //INCORRECTO
                if (opVoley.Checked)
                    mensaje += " Voley";     //INCORRECTO

                MessageBox.Show(mensaje);
            }
        }
    }
}
