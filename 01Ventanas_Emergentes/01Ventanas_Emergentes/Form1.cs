using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01Ventanas_Emergentes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMensaje_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta seguro de eliminar el archivo?", "Programcion IV",
                MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
        }

        private void btnCorto_Click(object sender, EventArgs e)
        {
            MessageBox.Show("MENSAJE CORTO");
        }
    }
}
