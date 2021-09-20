using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04ListoBox_ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(lstSaludo.SelectedItem.ToString() +
                " " + cmbDepartamentos.SelectedItem.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstSaludo.SelectedIndex = 1;
            cmbDepartamentos.SelectedIndex = 3;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //CREANDO LA PRIMERA COLUMNA
            ListViewItem nuevaColumna = new ListViewItem(txtCarnet.Text);
            //CREANDO LAS SIGUIENTES COLUMNAS
            nuevaColumna.SubItems.Add(txtNombre.Text);
            nuevaColumna.SubItems.Add(cmbClub.SelectedItem.ToString());
            //AÑADIENDO TODO AL LISTVIEW
            lista.Items.Add(nuevaColumna);

            //BORRANDO CAMPOS
            txtCarnet.Text = "";
            txtNombre.Text = "";

            //PONIENDO EL FOCO EN EL txtCarnet (UBICAR EL CURSOR)
            txtCarnet.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem filaEscogida in lista.SelectedItems)
            {
                filaEscogida.Remove();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
        }
    }
}
