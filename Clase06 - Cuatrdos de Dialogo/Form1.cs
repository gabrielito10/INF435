using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//ensamblado para abrir archivos
using System.IO;
namespace Clase06___Cuatrdos_de_Dialogo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            //DIRECTORIO INICIAL
            openFileDialog1.InitialDirectory = @"D:\Facilito";
            //NOMBRE DEL ARCHIVO
            openFileDialog1.FileName = "";
            //FILTRO
            openFileDialog1.Filter = "Archivitos de texto|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                txtContenido.Text = sr.ReadToEnd();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = @"D:\Recursos\INF435";
            saveFileDialog1.FileName = "Programacion IV";
            saveFileDialog1.Filter= "Archivitos de texto|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.Write(txtContenido.Text);
                sw.Close();
            }
        }
    }
}
