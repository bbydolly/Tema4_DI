#define TAMAÑO
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

//VALIDADO


//TODO---> Gestion acceptButton--->Con enter; tiene lugar cuando el control se convierte
//en el componente activo del formulario
namespace Ej2_Tema4_DI  //GESTIÓN ACCCEPTBUTTON. Pasae mensaje a negro si no hay error.

{




    //CancelButton es una propiedad del formulario que se le asigna a un botón
    //ShowInTaskBar--> No muestra la barra de tareas
    //MaximizeBox/MinimizeBox a false para que no aparezcan los controles de minimizar y maximizar
    //Cursor propiedad del formulario apra cambiar el ratón
    //From Border Style --> Fixed fijar el formulario
    public partial class Form1 : Form
    {
        int r, g, b;
        Color colorfondo;
        public Form1()
        {
            InitializeComponent();
            colorfondo = this.BackColor;
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
            
            //C:\Users\Cris\Downloads\foto.jpg


            lblInformativa.Text = "";
            lblInformativa.Visible = true;
            try
            {
                //Directivas de compolación apra hacer un reescalado de imagen manual 
#if TAMAÑO

                Image imagen = Image.FromFile(txtPath.Text);
                lblImage.Size = new Size(100, 70);
#else

                //  this.Size = new Size(1500, 1100);
                // this.Location = new Point(0, 0);
                //lblImage.Size = new Size(1366, 768);
#endif
                lblImage.Image = imagen;//Image.FromFile(txtPath.Text);

                lblInformativa.Text = "";
            }
            catch (FileNotFoundException)
            {
                //this.Size = new Size(900, 300);

                lblInformativa.ForeColor = Color.Red;
                lblInformativa.Text = "No se ha podido encontrar la ruta de la imagen";

            }
            catch (ArgumentException)
            {
                // this.Size = new Size(900, 300);

                lblInformativa.ForeColor = Color.Red;
                lblInformativa.Text = "No se ha podido encontrar la ruta de la imagen";
            }
            //this.Size = new System.Drawing.Size(1366,768);//ajusto el tamaño a la imagen
            // this.BackgroundImage = new Bitmap(txtPath.Text); //Con doble carácter de escape
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //Colección de controles 
            Control.ControlCollection coleccion = this.Controls;
            foreach (Control component in coleccion)
            {
                if (component is TextBox)
                {
                    component.Text = "";
                }
                if (component is Label)
                {
                    if (component == lblImage)
                    {
                        lblImage.Image = default;
                    }
                }
            }
            this.BackColor = colorfondo;


        }

        private void btnCambiarColor_Click(object sender, EventArgs e)
        {


            lblInformativa.ForeColor = Color.Black;
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

                this.BackColor = colorfondo;
                lblInformativa.ForeColor = Color.Red;
                lblInformativa.Text = "No se ha podido cambiar el color de fondo, los datos contenidos en los campos tipos text están erróneos.";
            }


        }

        private void MouseEnterBotones(object sender, EventArgs e)
        {

            ((Button)sender).BackColor = Color.Turquoise;


        }

        private void MouseLeaveBotones(object sender, EventArgs e)
        {

            ((Button)sender).BackColor = colorfondo;


        }

        private void btns_Botones_Genericos(object sender, EventArgs e)
        {
            if (sender == txtPath)//compruebo direcciones de memoria
            {
                this.AcceptButton = btnImagen;

            }

            //Sobreescritura del operador or o no se puede hacer (txtg||txtb||txtr)
            else if (sender == txtB || sender == txtG || sender == txtR) //(true<c) tipo de dato y comparacion
            {

                this.AcceptButton = btnCambiarColor;
            }
        }

        public bool ComprobarRangos(int rgb)
        {
            //if (rgb >= 0 && rgb <= 255)
            //{
            //    return true;

            //}
            //else
            //{
            //    return false;
            //}

            return rgb >= 0 && rgb <= 255; //ya devuelve tru o false
        }
    }
}
