using System;
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

        private void btnListBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lstDia.SelectedItem.ToString());
        }

        private void btnComboBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cmbDia.SelectedItem.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstDia.SelectedItem = "JUEVES";
            cmbDia.SelectedIndex = 3;
        }
    }
}
