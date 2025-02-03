using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
        Bitmap b;
        Form1 Form1 { get; set; }
        public Form2(string ruta, Form1 f)
        {
            InitializeComponent();

            pictureBox = new PictureBox();
            pictureBox.Anchor = AnchorStyles.None;//
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            b = new Bitmap(ruta);
            // pictureBox.Size =
            //Pongo al form el tamaño de la imagen 
            this.ClientSize = new Size(b.Width, b.Height);
            pictureBox.Image = new Bitmap(ruta);//Image.FromFile(archivosExtension[i].ToString());
            pictureBox.BorderStyle = BorderStyle.None;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.ContextMenuStrip = this.contextMenuStrip1;

            Debug.WriteLine(ruta.Substring(ruta.LastIndexOf("\\") + 1));
            this.Controls.Add(pictureBox);
            this.Text = ruta.Substring(ruta.LastIndexOf("\\") + 1);
            Form1 = f;
        }

        public void Avance_Retroceso(string ruta)
        {
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox.Image = new Bitmap(ruta);

            FileInfo file = new FileInfo(ruta);


            Form1.lblDatosImage.Text = "Name: " + file.Name + "\n" + "Tamaño: " + Conversion((double)file.Length) + "\nAncho: " + b.Width + "px" + "\nAlto: " + b.Height + "px";

            this.ClientSize = new Size(pictureBox.Image.Width, pictureBox.Image.Height);
            this.Text = ruta.Substring(ruta.LastIndexOf("\\") + 1);
        }



        public string Conversion(double byt)
        {
            string auxcad = "";
            int cont = 0;
            double aux = byt;
            Debug.WriteLine(byt + " bytes");

            while (aux > 1024)
            {
                aux = aux / 1024;
                cont++;
                Debug.WriteLine(cont + " contador");

                auxcad = aux.ToString("F2");
            }
            if (cont == 1)
            {

                auxcad += "KB";

            }
            else if (cont == 2)
            {
                auxcad += "MB";

            }
            else if (cont == 3)
            {
                auxcad += "gB";
            }


            return auxcad;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1.lblInfo.Text = "";
            Form1.lblDatosImage.Text = "";
            Form1.panel1.Controls.Clear();
            Form1.Size = new Size(400,150);
        }

        //TODO + cierra el secundario y borrar la lista de miniaturas
        //Mostrar el enu contextual
        private void anteriorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.btnRetroceso_Click(sender, e);
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Form1.btnAvance_Click(sender, e);
            this.Close();
        }
    }
}
