using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07PictureBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"D:\Diplomad";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Archivitos JPG|*.jpg|Archivitos PNG|*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = @"C:\Users\Gabriel\Pictures";
            saveFileDialog1.FileName = "Imagen01";
            saveFileDialog1.Filter = "Archivitos JPG|*.jpg|Archivitos PNG|*.png";
            if (saveFileDialog1.ShowDialog ()== DialogResult.OK)
            {
                pictureBox1.Image.Save(saveFileDialog1.FileName);
            }
        }
    }
}
