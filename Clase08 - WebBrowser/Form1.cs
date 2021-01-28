using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase08___WebBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIr_Click(object sender, EventArgs e)
        {
            // verificacion si el text no sea nulo o vacio
            if (string.IsNullOrEmpty(txtUrl.Text) == false)
            {
                miNavegador.Navigate(txtUrl.Text);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            miNavegador.GoBack();
        }

        private void btnAdelante_Click(object sender, EventArgs e)
        {
            miNavegador.GoForward();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            miNavegador.Refresh();
        }

        private void txtUrl_KeyUp(object sender, KeyEventArgs e)
        {
            if ( e.KeyCode == Keys.Enter)
            {
                miNavegador.Navigate(txtUrl.Text);
            }
        }
    }
}
