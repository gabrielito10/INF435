﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04ListBox_y_ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstDepartamentos.SelectedItem = "POTOSI";
            cmbDepartamentos.SelectedIndex = 3;
        }

        private void btnListBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BUENAS TARDES " + lstDepartamentos.SelectedItem);
        }

        private void btnComboBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BUENAS TARDES " + cmbDepartamentos.SelectedItem);
        }
    }
}
