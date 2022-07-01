using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _10Proyecto
{
    public partial class frmCliente : Form
    {
        BindingSource miBinding = new BindingSource();
        public frmCliente()
        {
            InitializeComponent();
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            BaseDeDatos miBase = new BaseDeDatos();
            DataSet ds = miBase.SeleccionTabla("CLIENTE");
            miBinding.DataSource = ds.Tables[0];
            txtCI.DataBindings.Add("Text", miBinding, "CI");
            txtNombre.DataBindings.Add("Text", miBinding, "NOMBRE");
            txtCelular.DataBindings.Add("Text", miBinding, "CELULAR");
            cmbDepartamentos.DataBindings.Add("Text", miBinding, "NACIMIENTO");
            dataGridView1.DataSource = miBinding;
        }

        private void cmdPrimer_Click(object sender, EventArgs e)
        {
            miBinding.MoveFirst();
        }

        private void cmdAnterior_Click(object sender, EventArgs e)
        {
            miBinding.MovePrevious();
        }

        private void cmdSiguinte_Click(object sender, EventArgs e)
        {
            miBinding.MoveNext();
        }

        private void cmdUltimo_Click(object sender, EventArgs e)
        {
            miBinding.MoveLast();
        }
    }
}
