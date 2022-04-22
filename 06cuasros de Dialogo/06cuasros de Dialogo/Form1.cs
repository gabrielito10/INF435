using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _06cuasros_de_Dialogo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory = @"D:\Prueba";
            openFileDialog1.Filter = "Archivitos de texto|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                Texto.Text = sr.ReadToEnd();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "";
            saveFileDialog1.InitialDirectory = @"D:\Prueba";
            saveFileDialog1.Filter = "Archivitos de texto|*.txt";
            if (saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.Write(Texto.Text);
                sw.Close();
            }
        }
    }
}
