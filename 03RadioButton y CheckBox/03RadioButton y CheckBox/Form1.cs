﻿using System;
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

        private void btnEstadoCivil_Click(object sender, EventArgs e)
        {
            if (opSoltero.Checked == true)
                MessageBox.Show("Ud. Es Soltero");
            if (opCasado.Checked == true)
                MessageBox.Show("Ud. Casado");
            if (opDivorciado.Checked)
                MessageBox.Show("Ud. es divorciado");
            if (opViudo.Checked)
                MessageBox.Show("Ud. es viudo");
        }

        private void btnMascota_Click(object sender, EventArgs e)
        {
            if (opPerros.Checked == false && opGatos.Checked == false &&
                opAves.Checked == false && opPezcado.Checked == false)
                MessageBox.Show("A ud. no le gusta las mascotas");
            else
            {
                string cadena = "A ud. le gusta los ";
                if (opPerros.Checked)
                    cadena=cadena + "perros ";
                if (opGatos.Checked)
                    cadena= cadena+"gatos ";
                if (opAves.Checked)
                    cadena+="aves ";
                if (opPezcado.Checked)
                    cadena+="pezcados";
                MessageBox.Show(cadena);
            }
        }
    }
}
