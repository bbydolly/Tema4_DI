//#define A
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//VALIDADO


namespace Tema4_DI
{



    // rEVISAR COOR EN BOTONES---Listo
    // Liberación botones---listo 
    // Eventos de teclado para Unicode---listo
    //    Icono
    //    título 
    //    Orden de tabulación
    //     AcceptButton-->BOTTON QUE ACEPTA LA TECLA ENTER
    //    CancelButton --->BOTÓN QUE ACEPTA LA TECLA ESC


    //KeyPreview
    //Propiedad que si se pone a TRUE provoca que la gestión del teclado sea realizada
    //mediante los eventos del formulario y no sobre los eventos de teclado de cada uno
    //de los componentes
    public partial class Form1 : Form
    {

        public int x;
        public int y;

        public int xBoton = 39;
        public int yBoton = 100;
        public int cont = 1;



        public Form1()
        {
            InitializeComponent();
            Button btn;
            List<Button> buttons = new List<Button>();


            for (int j = 0; j < 20; j++)
            {
                btn = new Button();
                btn.TabIndex = cont++;
                btn.Name = j.ToString();
                btn.Text = (j + 1).ToString();
                btn.Size = new System.Drawing.Size(75, 23);

                if (j % 5 == 0)
                {
                    yBoton += 50;
                    xBoton = 39;
                }
                else
                {
                    xBoton += 124;
                }
                btn.Location = new Point(xBoton, yBoton);
                btn.Enabled = true;

                btn.Click += new System.EventHandler(this.btnsClick); //Se gestiona todo
                //Diferencia con MouseClick es un evento de click del ratón
                buttons.Add(btn);
                btn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
                //Probarlo con la barra espaciadora
                this.Controls.Add(btn);
                //Todo: perguntarle a Curro si esto se hace?

            }


        }


        private void btnsClick(object sender, EventArgs e)
        {
            this.Text = ((Button)sender).Text.ToString();

        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            // Point p = e.Location;
            //Desde e--> e.X e.Y
            if (sender == this)
            {
                this.Text = "X: " + e.X.ToString() + " Y: " + e.Y.ToString(); //devuelve x e y
                x = e.X;
                y = e.Y;
            }
            else
            {

                //Si se hace lento funciona, es por un tema de cargar los datos?
                // this.Text = "X: " + (e.X + x).ToString() + " Y: " + (e.Y + y).ToString(); //devuelve x e y

                //Bien
                //Coordenada del boton respecto al formulario, esquina superior izqueirda respecto al formulario +
                //Coordenadas del propio botón que empiezan en 0,0
                //El tostring() se hace a la suma total
                this.Text = "X: " + (((Control)sender).Location.X + e.Location.X).ToString() + " Y: " + (((Control)sender).Location.Y + e.Location.Y).ToString();

                Debug.WriteLine("Coordenadas del botón X:" + e.Location.X.ToString() + " Y: " + e.Location.Y.ToString());
                Debug.WriteLine("Coordenadas del botón  respecto al formulario esquina superior izqueirda X:" + ((Control)sender).Location.X + " Y: " + ((Control)sender).Location.Y);



            }

        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            this.Text = "Mouse Tester";
        }



        //Todo gestión de click con el mouse


        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {


            if (e.Button == MouseButtons.Left)
            {
                button1.BackColor = Color.Turquoise;
            }



            else if (e.Button == MouseButtons.Right)
            {
                button2.BackColor = Color.Yellow;
            }
            else
            {
                button1.BackColor = Color.Turquoise;
                button2.BackColor = Color.Yellow;
            }


        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            //Mouse up diferenciarlo según sea un lado del ratón u el otro, no los dos a la vez
            if (e.Button == MouseButtons.Left)
            {
                button1.BackColor = Color.White;

            }

            else if (e.Button == MouseButtons.Right)
            {
                button2.BackColor = Color.White;
            }
            else
            {

                button1.BackColor = Color.White;
                button2.BackColor = Color.White;
            }




        }




        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "Botones en tiempo de ejecución y ratón",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
#if A

            if (e.KeyCode == Keys.Escape)//Key code y key value es lo mismoe xpresado de diferentes maneras
            {
                this.Text = "Mouse Tester";
            }
            else
            {

                //KeyValue me da el numero asociado a la tecl
                this.Text = e.KeyValue.ToString(); //numero de tecla 

              

            }
            
           

#endif 
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
#if !A
            if (e.KeyChar == (char)Keys.Escape)//Key code y key value es lo mismoe xpresado de diferentes maneras
            {
                this.Text = "Mouse Tester";
            }
            else
            {

                this.Text = e.KeyChar.ToString(); //caracter pulsado j,i,K,L,j,p...etc (tanto mayusc como minúsculas)



            }
#endif

        }

    }
}
