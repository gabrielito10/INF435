using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07DateTimePicker_WebBowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void btnAdelante_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void txtUrl_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                webBrowser1.Navigate(txtUrl.Text);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToString());
            //MessageBox.Show(dateTimePicker1.Text);
        }
    }
}
