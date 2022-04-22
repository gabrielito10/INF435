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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Creando la nueva fila con el campo usuario
            ListViewItem nuevaFila = new ListViewItem(txtUsuario.Text);
            //agregando el telefono a la fila
            nuevaFila.SubItems.Add(txtTelefono.Text);
            //agregando el email a la fila
            nuevaFila.SubItems.Add(txtEmail.Text);
            //añadimos la nueva fila al listview
            Lista.Items.Add(nuevaFila);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Lista.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //barremos la lista buscando los elementos seleccionados
            foreach( ListViewItem FilaEscogida in Lista.SelectedItems)
            {
                FilaEscogida.Remove();
            }
        }
    }
}
