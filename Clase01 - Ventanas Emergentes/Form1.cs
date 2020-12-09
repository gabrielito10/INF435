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
            if (MessageBox.Show("Desea eliminar este archivo?", "Programacion IV",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //aca esta la respuesta por el si
            }
            else if (MessageBox.Show("Desea eliminar este archivo?", "Programacion IV",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.No)
            {
                //aca esta la respuesta por el no
            }
            else if (MessageBox.Show("Desea eliminar este archivo?", "Programacion IV",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)==DialogResult.Cancel)
            {
                //aca esta la respuesta por el cancelar
            }
            else
            {
                //por si no escogio ninghuna respuesta
            }
        }
    }
}
