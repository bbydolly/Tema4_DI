using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public Form2(String ruta)
        {
            InitializeComponent();
            PictureBox pictureBox=new PictureBox();
            pictureBox.Image = new Bitmap(ruta);//Image.FromFile(archivosExtension[i].ToString());
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.BorderStyle = BorderStyle.None;
            pictureBox.Size = new Size(this.ClientSize.Width,this.ClientSize.Height );
            this.Controls.Add( pictureBox );
        }
    }
}
