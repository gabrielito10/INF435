using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05Navegador_Fecha
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

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Navegador.GoBack();
        }

        private void btnAdelante_Click(object sender, EventArgs e)
        {
            Navegador.GoForward();
        }

        private void bntActualizar_Click(object sender, EventArgs e)
        {
            Navegador.Refresh();
        }

        private void txtUrl_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Navegador.Navigate(txtUrl.Text);
            }
        }
    }
}
