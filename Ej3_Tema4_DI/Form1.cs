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

    //Pendiente de VALIDACIÓN



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




                if (openFileDialog.ShowDialog() == DialogResult.OK) //Abrir es OK
                {
                    //Código común a ambas formas del formulario s
                    filePath = openFileDialog.FileName;

                    Formulario2 f2 = new Formulario2(openFileDialog.SafeFileName); //Nombre del archivo

                    Debug.Write(filePath);
                    Image imagen = System.Drawing.Image.FromFile(filePath);
                    f2.pictureBox1.Image = imagen;
                    f2.pictureBox1.Size = new Size(imagen.Size.Width, imagen.Size.Height);
                    f2.Size = new Size(imagen.Size.Width, imagen.Size.Width);

                    if (cbModal.Checked)
                    {

                        f2.ShowDialog();// formulario modal
                    }
                    else //Abrir es OK
                    {

                        f2.Show();
                    }


                }


            }





        }

        private void cbModal_CheckedChanged(object sender, EventArgs e)
        {
            if (cbModal.Checked)
            {
                cbModal.ForeColor = Color.Red;

            }
            else
            {
                cbModal.ForeColor = Color.Black;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "Cierre de formulario",
              MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
              == DialogResult.Cancel)
            {
                e.Cancel = true; //Cancela el cierre
            }
        }
    }
}
