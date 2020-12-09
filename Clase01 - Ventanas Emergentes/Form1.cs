using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase01___Ventanas_Emergentes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMensaje_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desea eliminar este archivo?", "Programacion IV",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        }
    }
}
