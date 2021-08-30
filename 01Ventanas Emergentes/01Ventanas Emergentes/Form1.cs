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
            MessageBox.Show("Es es mi mensaje");
        }

        private void btnPersonalizada_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show("Ud. quiere aprobar la materia de INF435?", "Programacion IV",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                     
        }

        private void btnRespuesta_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ud. quiere aprobar la materia de INF435?", "Programacion IV",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Ud. quiere aprobar");
            }
            else if (MessageBox.Show("Ud. quiere aprobar la materia de INF435?", "Programacion IV",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.No)
            {
                MessageBox.Show("UNos vemos al otro semestre");
            }
            else
            {
                MessageBox.Show("Ud. decidio ya no programar la asignatura");
            }

        }
    }
}
