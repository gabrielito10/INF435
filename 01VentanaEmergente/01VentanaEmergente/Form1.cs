using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01VentanaEmergente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void miBotoncito_Click(object sender, EventArgs e)
        {
            //sacando mensaje con las 4 opciones
            MessageBox.Show("Desea eliminar este archivo?","Programacion IV",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            
            
        }

        private void btnDirecto_Click(object sender, EventArgs e)
        {
            //sacando mensaje directo
            MessageBox.Show("Este es un mensaje directo");
        }

        private void btnCaptura_Click(object sender, EventArgs e)
        {
            //captpurando el boton
           if ( MessageBox.Show("Aqui vamos a capturar que boton se presiono", "Programacion IV",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Ud presiono Aceptar");
            }
        }
    }
}
