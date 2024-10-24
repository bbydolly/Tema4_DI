using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej3_Tema4_DI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNuevaImagen_Click(object sender, EventArgs e)
        {
            Console.Write("funciona");
            string fileContent = string.Empty;
            string filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            // Se puede declarar aquí o por código en el designer 
            {
                openFileDialog.InitialDirectory = "C:\\Users\\Cris\\Pictures";
                openFileDialog.Filter = "txt files |*.txt|PNG|*.png|JPG|*.jpg|All files (*.*) |*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                //Get the path of specified file
                Formulario2 f2 = new Formulario2();




                if (cbModal.Checked)
                {
                    if (openFileDialog.ShowDialog() == DialogResult.OK) //Abrir es OK
                    {
                        filePath = openFileDialog.FileName;
                        Console.Write(filePath);
                        Image imagen = System.Drawing.Image.FromFile(filePath);
                        f2.pictureBox1.Image = imagen;
                        f2.pictureBox1.Size = new Size(imagen.Size.Width, imagen.Size.Height);
                        f2.Size = new Size(imagen.Size.Width, imagen.Size.Width);
                        f2.ShowDialog();// formulario modal
                    }
                }
                else
                {
                    if (openFileDialog.ShowDialog() == DialogResult.OK) //Abrir es OK
                    {

                        f2.Show();
                    }
                }

                ////Read the contents of the file into a stream
                //Stream fileStream = openFileDialog.OpenFile();

                //using (StreamReader reader = new StreamReader(fileStream))
                //{
                //    fileContent = reader.ReadToEnd();
                //}
            }

            //MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);



        }
    }
}
