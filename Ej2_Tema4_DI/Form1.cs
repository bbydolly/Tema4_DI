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

namespace Ej2_Tema4_DI
{

    //CancelButton es una propiedad del formulario que se le asigna a un botón
    public partial class Form1 : Form
    {
        int r, g, b;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

            this.Close();// close pasa por el closing
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "Botones en tiempo de ejecución y ratón",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == DialogResult.Cancel)
            {
                e.Cancel = true; //Cancela el cierre
            }
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            //No cumple especificación
            //de fondo en una label
            //C:\Users\Cris\Downloads\foto.jpg
            // lblImage.Text = "";


            lblImage.Visible = true;
            try
            {
                Image imagen = Image.FromFile(txtPath.Text);
                this.Size = new Size(1500, 1100);
                this.Location = new Point(0, 0);
                lblImage.Size = new Size(1366, 768);
                lblImage.Image = imagen;//Image.FromFile(txtPath.Text);
                Debug.WriteLine("Entra en el try");
            }
            catch (FileNotFoundException)
            {
                this.Size = new Size(900, 300);
                lblImage.Visible = false;
                lblImage.ForeColor = Color.Red;
                lblImage.Text = "No se ha podido encontrar la ruta de la imagen";

            }
            catch (ArgumentException)
            {
                this.Size = new Size(900, 300);
                lblImage.Visible = false;
                lblImage.ForeColor = Color.Red;
                lblImage.Text = "No se ha podido encontrar la ruta de la imagen";
            }
            //this.Size = new System.Drawing.Size(1366,768);//ajusto el tamaño a la imagen
            // this.BackgroundImage = new Bitmap(txtPath.Text); //Con doble carácter de escape
        }

        private void btnCambiarColor_Click(object sender, EventArgs e)
        {
            lblInformativa.Text = "Introduce en cada textbox números entre 0-255 ,corresponden a colores.";

            if (int.TryParse(txtR.Text, out r) && int.TryParse(txtG.Text, out g) && int.TryParse(txtB.Text, out b)) //con independiencia de si devuelve true o false out contiene la cadena
            {

                if (ComprobarRangos(r) && ComprobarRangos(g) && ComprobarRangos(b))
                {
                    this.BackColor = Color.FromArgb(r, g, b);
                }

            }
            else
            {

                this.BackColor = Color.White;
                lblInformativa.ForeColor = Color.Red;
                lblInformativa.Text = "No se ha podido cambiar el color de fondo, los datos contenidos en los campos tipos text están erróneos.\nSe ha cambiado el color de fondo a blanco.";
            }


        }

        public bool ComprobarRangos(int rgb)
        {
            if (rgb >= 0 && rgb <= 255)
            {
                return true;

            }
            else
            {
                return false;
            }
        }
    }
}
