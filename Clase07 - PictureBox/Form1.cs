using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase07___PictureBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\Users\Gabito\Pictures";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Archivitos de tipo JPG|*.jpg" +
                "|Archivitos PNG|*.png|Archivitos bmp|*.bmp|Archivitos GIF|*.gif";
            //como van los filtros
            //Texto|extension que vamos a filtrar
            //poner los filtro dividiso por "|"
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picImagen.Load(openFileDialog1.FileName);
            }
        }
    }
}
