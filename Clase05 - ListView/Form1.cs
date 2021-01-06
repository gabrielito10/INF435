using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase05___ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Crear un item con la primera columna
            ListViewItem nuevo = new ListViewItem(txtCI.Text);
            // agregando la columna nombre
            nuevo.SubItems.Add(txtNombre.Text);
            // agregando columna lugar nacimiento
            nuevo.SubItems.Add(cmbDep.SelectedItem.ToString());
            // agregando columna estado civil
            string estado_civil = "";
            if (opSol.Checked == true)
                estado_civil = opSol.Text;
            if (opCas.Checked == true)
                estado_civil = opCas.Text;
            if (opDiv.Checked == true)
                estado_civil = opDiv.Text;
            if (opViu.Checked == true)
                estado_civil = opViu.Text;
            nuevo.SubItems.Add(estado_civil);
            //cargando todo el item al LisView
            lstPersona.Items.Add(nuevo);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // ELIMINANDO UNA FILA
            foreach(ListViewItem filaEscogida in lstPersona.SelectedItems)
            {
                filaEscogida.Remove();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lstPersona.Items.Clear();
        }
    }
}
