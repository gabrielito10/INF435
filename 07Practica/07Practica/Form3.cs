using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07Practica
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (lstColegios.SelectedItem.ToString() == "PICHINCHA")
                MessageBox.Show("Ud. Es Pichicncheño");
            //tabajando con el index
            if (lstColegios.SelectedIndex == 1)
                MessageBox.Show("Ud. es calereño");
            if (lstColegios.SelectedIndex == 2)
                MessageBox.Show("Ud. es Braunista");
        }
    }
}
