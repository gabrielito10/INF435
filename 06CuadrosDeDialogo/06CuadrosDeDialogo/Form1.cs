using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//AGRAGANDO ENSAMBLADO PARA FORMATO DE IMAGEN
using System.Drawing.Imaging;

namespace _06CuadrosDeDialogo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            //Directorio de Inicio
            openFileDialog1.InitialDirectory = @"C:\Users\Gabriel\Pictures";
            //Nombre del archivo
            openFileDialog1.FileName = "";
            //filtrar archivos de tipo imagen BMP, PNG, JPG
            // Texto|Nombre.Extension1|Texto|Nombre.Extension2
            openFileDialog1.Filter = "Archivitos BMP|*.BMP|Archivitos JPG|*.JPG"+
                "|Archivitos PNG|*.PNG";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //cargando imagen dentro del picture box
                miImagen.Load(openFileDialog1.FileName);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Directorio Inicial
            saveFileDialog1.InitialDirectory = @"D:\";
            //Nombre de Archivo
            saveFileDialog1.FileName = "MiImagen";
            ImageFormat formato = ImageFormat.Png;

            //filtro
            saveFileDialog1.Filter= "Archivitos BMP|*.BMP|Archivitos JPG|*.JPG" +
                "|Archivitos PNG|*.PNG";
            if (saveFileDialog1.ShowDialog() ==DialogResult.OK)
            {
                string extension = System.IO.Path.GetExtension(saveFileDialog1.FileName);
                switch(extension)
                {
                    case ".jpg":
                        formato = ImageFormat.Jpeg;
                        break;
                    case ".png":
                        formato = ImageFormat.Png;
                        break;
                    case ".bmp":
                        formato = ImageFormat.Bmp;
                        break;

                }
                //Descargando la Imagen
                miImagen.Image.Save(saveFileDialog1.FileName, formato);
            }
        }
    }
}
