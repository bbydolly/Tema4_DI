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

namespace Ej4_Tema4_DI
{
  //  Validado

    public partial class Form1 : Form
    {
        public delegate int Operar(int n1, int n2);
        int n1, n2;
        int cont = 0;
        Dictionary<string, Operar> simbolosOperaciones;

        public Form1()
        {
            InitializeComponent();
            simbolosOperaciones = new Dictionary<string, Operar>();
            simbolosOperaciones.Add(rbSuma.Text, (n1, n2) => n1 + n2);
            simbolosOperaciones.Add(rbResta.Text, (n1, n2) => n1 - n2);
            simbolosOperaciones.Add(rbMultiplicacion.Text, (n1, n2) => n1 * n2);
            simbolosOperaciones.Add(rbDivision.Text, (n1, n2) => n1 / n2);
            this.Text = "00:00";
           

        }

        private void rbs_CheckedChanged(object sender, EventArgs e)
        {
            lblOperacion.Text = ((RadioButton)sender).Text;
        }

        private void txts_ComprobarCadena(object sender, EventArgs e)
        {
            if (int.TryParse(((TextBox)sender).Text, out int n1))
            {
                ((TextBox)sender).ForeColor = Color.Black;
            }
            else
            {
                ((TextBox)sender).ForeColor = Color.Red;
            }

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            //formato con dos cifras
            //cociente--minutos
            //resto ---segundos
            this.Text = string.Format("{0:00}:{1:00}", cont/60, cont%60);
            cont++;
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            lblIgual.Text = "=";
            RadioButton rb;
            bool aux1, aux2;


            Debug.WriteLine("Entra en btnOperar");
            if ((int.TryParse(textBox1.Text, out int num)) && int.TryParse(textBox2.Text, out int num2))
            {
                Debug.WriteLine("Entra en el if");
                Control.ControlCollection coleccion = this.Controls;
                Debug.WriteLine(lblOperacion.Text);

                lblIgual.Text += simbolosOperaciones[lblOperacion.Text](num, num2);

                //foreach (Control c in coleccion)//SIn bucles (accediendo direcamente a la jhas con clave text de la etiqueta
                //{
                //    if (c is RadioButton)
                //    {
                //        if (((RadioButton)c).Checked)
                //        {
                //            rb = (RadioButton)c;


                //            foreach (KeyValuePair<string, Operar> operacion in simbolosOperaciones)
                //            {
                //                if (operacion.Key == rb.Text)
                //                {
                //                    Debug.WriteLine("Entra en el if key");
                //                    lblIgual.Text += "  " + (operacion.Value(num, num2)).ToString();
                //                }

                //            }
                //        }
                //    }
                //}
            }
        }

    }


}
