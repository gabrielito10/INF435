using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06CheckListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            lstSeleccionados.Items.Clear();
            for (int i=0; i<lstColores.CheckedItems.Count; i++)
            {
                lstSeleccionados.Items.Add(lstColores.CheckedItems[i].ToString());
            }
            label1.Text = "Son " + lstColores.CheckedItems.Count.ToString() +
                " elementos seleccionados";
        }
    }
}
