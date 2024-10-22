#define CARACTER
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

namespace Tema4_DI
{
    //Pendiente de validación y de poner Icono

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

                btn.Click += new System.EventHandler(this.btnsClick);
                buttons.Add(btn);
                this.Controls.Add(btn);
                //Todo: perguntarle a Curro si esto se hace?
                //  btn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);

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
                this.Text = "X: " + (e.X + x).ToString() + " Y: " + (e.Y + y).ToString(); //devuelve x e y


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
            if (button1.BackColor == Color.Turquoise)
            {
                button1.BackColor = Color.White;
            }
            if (button2.BackColor == Color.Yellow)
            {
                button2.BackColor = Color.White;
            }
        }



        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Text = "Mouse Tester";
            }
            else
            {
#if CARACTER
                this.Text = e.KeyCode.ToString(); //TECLA PULSADA K,A,F...
#else
                this.Text = e.KeyValue.ToString();//código asociado a la tecla ej:A--65
                Debug.WriteLine(e.KeyCode.ToString());
#endif
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
    }
}
