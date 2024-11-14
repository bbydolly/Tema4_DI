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

namespace Ej6_Tema4_DI
{

    //Pendiente de VALIDACIÓN


    public partial class Form1 : Form
    {
        public Button btn;
        public string[] caracteres = { "*", "0", "#" };
        public int x;
        public int y;
        public Form2 f2;
        public DialogResult res;
        int cont = 3;
        public bool flag = true;
        public TextBox txtEscribir;
        // public Color colorfondo;
        public Form1()
        {
            //Propiedad text anteponer & para navegacion por nemonicos
            InitializeComponent();
            this.Text = "Teclado de teléfono";
            //PaswordChar, propiedad del txtBox




            for (int i = 0; i < 9; i++)
            {
                btn = new Button();
                btn.Name = i.ToString();
                btn.Text = (i + 1).ToString();
                btn.Size = new System.Drawing.Size(30, 30);

                if (i % 3 == 0)
                {
                    x = 40;
                    y += 40;
                }
                else
                {
                    x += 40;
                }
                btn.Location = new System.Drawing.Point(x, y);
                //añadir el click
                btn.Click += new System.EventHandler(btn_Click);
                btn.MouseEnter += new System.EventHandler(btns_MouseEnter);
                btn.MouseLeave += new System.EventHandler(btns_MouseLeave);
                Controls.Add(btn);


            }
            x = 40;
            y += 40;
            for (int i = 0; i < caracteres.Length; i++)
            {
                btn = new Button();
                btn.Name = caracteres[i];
                btn.Text = caracteres[i];
                btn.Size = new System.Drawing.Size(30, 30);
                btn.Location = new System.Drawing.Point(x, y);
                btn.Click += new System.EventHandler(btn_Click);
                btn.MouseEnter += new System.EventHandler(btns_MouseEnter);
                btn.MouseLeave += new System.EventHandler(btns_MouseLeave);

                Controls.Add(btn);
                x += 40;
            }


            //TextBox donde se escriben los números
            txtEscribir = new TextBox();
            txtEscribir.Name = "txtEscribir";
            txtEscribir.Text = "";
            txtEscribir.Size = new System.Drawing.Size(80, 20);
            txtEscribir.Location = new System.Drawing.Point(50, 200);
            txtEscribir.Multiline = true;
            Controls.Add(txtEscribir);


            //btn reset
            btn = new Button();
            btn.Name = "btnReset";
            btn.Text = "Reset";
            btn.Location = new System.Drawing.Point(60, 250);
            btn.Size = new System.Drawing.Size(60, 30);
            btn.Click += new System.EventHandler(btn_Reset);
            Controls.Add(btn);




        }

        public void btn_Reset(object sender, EventArgs e)
        {
            txtEscribir.Text = "";
            Control.ControlCollection cbotones = this.Controls;//Colección de controles

            foreach (Control c in cbotones)
            {
                if (c.GetType() == typeof(Button))
                {
                    ((Button)c).BackColor = Color.White;
                }
            }
        }

        //Click botton
        public void btn_Click(object sender, EventArgs a)
        {
            txtEscribir.Text += ((Button)sender).Text;
            ((Button)sender).BackColor = Color.Red;
        }


        //Tiene lugar cuando se carga el formulario
        private void Form1_Load(object sender, EventArgs e)
        {
            while (flag)
            {
                f2 = new Form2();

                res = f2.ShowDialog();

                switch (res)
                {
                    //La propiedad Dialog result del boton a ok, hace que al clicar el formulario secundario se oculte
                    case DialogResult.OK:
                        if (f2.txtPin.Text == "1111")
                        {
                            //MessageBox.Show("Contraseña aceptada", "Introducir contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            res = 0;
                            flag = false;
                        }
                        else
                        {
                            cont--;
                            Debug.WriteLine("Cancel");

                            if (cont > 0)
                            {
                                MessageBox.Show($"Contraseña errónea,te quedan {cont} intentos", "Introducir contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                f2.txtPin.Text = "";
                                //Environment.Exit(0);
                                //f2.Show();
                            }
                            else
                            {
                                MessageBox.Show($"Contraseña errónea,te quedan {cont} intentos", "Introducir contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                flag = false;
                                this.Close();

                            }
                        }
                        break;


                }
            }
        }



        private void btns_MouseEnter(object sender, EventArgs e)
        {
            if (((Button)sender).BackColor != Color.Red)
            {
                ((Button)sender).BackColor = Color.Aqua;

            }
        }
        private void btns_MouseLeave(object sender, EventArgs e)
        {
            if (((Button)sender).BackColor != Color.Red)
            {
                ((Button)sender).BackColor = Color.White;

            }
        }

        private void grabarNúmeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Guardo archivo de texto
            if (txtEscribir.Text != "")
            {
                //Pide al usuario que sleccione una ubicacion de un archivo 
                SaveFileDialog saveFileDialog = new SaveFileDialog();

                //OverwritePrompt: Propiedad que evita que te salga un cuadro para sobreescribir el archivo
                saveFileDialog.OverwritePrompt = false;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {

                    //Cojo la ruta completa con el nombre del archivo
                    string rutaNombre = saveFileDialog.FileName;
                    StreamWriter sw = new StreamWriter(rutaNombre, true);//Añado al archivo con append a true
                                                                         //Escribir en el archivo 
                    sw.WriteLine(txtEscribir.Text);
                    sw.Close();
                }


            }
        }


        private void acerdaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Qué información de la app?
            string info = "Autora Cris\nAplicación que permite la introducción y el guardado de números de teléfono.";
            MessageBox.Show(info, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    e.Cancel = false;
        //}


    }
}
