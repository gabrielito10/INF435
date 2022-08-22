using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01Ventanas_Emergente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPregunta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¿Desea eliminar el archivo?",
                "Programcion IV",MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
        }

        private void btnMensaje_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este es un mensaje");
        }
    }
}
