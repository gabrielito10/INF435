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
            //creando la primera fila
            ListViewItem nuevaFila = new ListViewItem(txtNombre.Text);
            //añadiendo la segunda columna
            nuevaFila.SubItems.Add(txtCarrera.Text);
            //añadiendo la tercera columna
            nuevaFila.SubItems.Add(txtTelefono.Text);
            //cargando el item en el objeto listView
            lstEstudiante.Items.Add(nuevaFila);
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem filaEscogida in lstEstudiante.SelectedItems)
            {
                filaEscogida.Remove();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstEstudiante.Clear();
        }
    }
}
