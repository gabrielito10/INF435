using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07DateTimePicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            // El Text muestra lo que esta en el objeto
            //MessageBox.Show(dateTimePicker1.Text);

            MessageBox.Show(dateTimePicker1.Value.ToString());
        }
    }
}
