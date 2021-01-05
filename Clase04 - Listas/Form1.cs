using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase04___Listas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             //lstDepartamentos.SelectedIndex = 4;
             //cmbDepartamentos.SelectedItem = "POTOSI";
        }

        private void btnComboBox_Click(object sender, EventArgs e)
        {
           MessageBox.Show("BUENOS DIAS " + cmbDep.SelectedItem);
        }

        private void btnLisBox_Click(object sender, EventArgs e)
        {
          MessageBox.Show("BUENOD DIAS " + lstDep.SelectedItem);
        }
    }
}
