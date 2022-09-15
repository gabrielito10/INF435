using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08PictureBox_y_Cuadros_de_Dialogo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"D:\Fondos";
            openFileDialog1.Filter = "Archivitos JPG|*.jpg|" +
                "Archivitos PNG|*.png|Archivitos GIF|*.gif";
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = @"C:\Users\Gabriel\Desktop";
            saveFileDialog1.Filter = "Archivitos JPG|*.jpg|" +
                "Archivitos PNG|*.png|Archivitos GIF|*.gif";
            saveFileDialog1.FileName = "PorDefecto";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(saveFileDialog1.FileName);
            }
        }
    }
}
