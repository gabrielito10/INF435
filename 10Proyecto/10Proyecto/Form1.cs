using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10Proyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void registroDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente x = new frmCliente();
            x.MdiParent = this;
            x.Show();
        }

        private void rEgistroDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProducto x = new frmProducto();
            x.MdiParent = this;
            x.Show();
        }

        private void registroDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVentas x = new frmVentas();
            x.MdiParent = this;
            x.Show();
        }
    }
}
