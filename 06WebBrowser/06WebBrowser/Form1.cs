using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06WebBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnIR_Click(object sender, EventArgs e)
        {
            miNavegador.Navigate(txtEnlace.Text);
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            miNavegador.GoBack();
        }

        private void btnAdelante_Click(object sender, EventArgs e)
        {
            miNavegador.GoForward();
        }

        private void txtEnlace_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                miNavegador.Navigate(txtEnlace.Text);
        }
    }
}
