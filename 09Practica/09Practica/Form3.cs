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

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            String texto = "Ud. es ";
            texto += cmbGenero.SelectedItem;
            if (chkRojo.Checked == false && chkAmarillo.Checked == false
                && chkVerde.Checked == false)
                texto += " no le gusta ningun color";
            else
            {
                texto += " y le gusta el color ";
                if (chkRojo.Checked)
                    texto += " " + chkRojo.Text;
                if (chkAmarillo.Checked)
                    texto += " " + chkAmarillo.Text;
                if (chkVerde.Checked)
                    texto += " " + chkVerde.Text;
            }
            MessageBox.Show(texto);
        }
    }
}
