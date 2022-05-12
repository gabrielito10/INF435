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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string cadena = "Ud. tiene ";
            if (rbtMenor.Checked == true)
                cadena += rbtMenor.Text;
            if (rbtMayor.Checked)
                cadena += rbtMayor.Text;
            cadena += " años y ";
            if (chk430.Checked == false &&
                chk435.Checked == false)
            {
                cadena += "no tiene materias programadas";
            }
            else
            {
                cadena += " programo ";
                if (chk430.Checked)
                    cadena += chk430.Text + " ";
                if (chk435.Checked)
                    cadena += chk435.Text + " ";
            }
            MessageBox.Show(cadena);
        }
    }
}
