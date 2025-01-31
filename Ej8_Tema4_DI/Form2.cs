using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej8_Tema4_DI
{

    public partial class Form2 : Form
    {
        PictureBox pictureBox;
        public Form2(string ruta)
        {
            InitializeComponent();

            pictureBox = new PictureBox();
            pictureBox.Anchor = AnchorStyles.None;//
            pictureBox.Dock = DockStyle.Fill;
            Bitmap b = new Bitmap(ruta);
            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            // pictureBox.Size =
            //Pongo al form el tamaño de la imagen 
            this.ClientSize = new Size(b.Width, b.Height);
            pictureBox.Image = new Bitmap(ruta);//Image.FromFile(archivosExtension[i].ToString());
            pictureBox.BorderStyle = BorderStyle.None;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            Debug.WriteLine(ruta.Substring(ruta.LastIndexOf("\\")+1));
            this.Controls.Add(pictureBox);
            this.Text = ruta.Substring(ruta.LastIndexOf("\\")+1);
        }

        public void Avance(String ruta)
        {
            //pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Image = new Bitmap(ruta);
        }

        public void Retroceso(String ruta)
        {
            //pictureBox.SizeMode = PictureBoxSizeMode.Zoom;


            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Image = new Bitmap(ruta);
        }
    }
}
