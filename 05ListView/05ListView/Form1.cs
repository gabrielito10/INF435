using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            //Creando una nueva fila con la primera columna que es el CI
            ListViewItem nuevaFila = new ListViewItem(txtCI.Text);

            //Añadiendo las columnas restantes
            nuevaFila.SubItems.Add(txtNombre.Text);
            nuevaFila.SubItems.Add(txtCelular.Text);

            //cargando la fila al ListView
            Lista.Items.Add(nuevaFila);

            //Limpiando los TextBox
            txtCI.Text = "";
            txtNombre.Text = "";
            txtCelular.Text = "";

            //Dando el foco al txtCI
            txtCI.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Lista.Items.Clear();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem filaSeleccionada in Lista.SelectedItems)
            {
                filaSeleccionada.Remove();
            }
        }
    }
}
