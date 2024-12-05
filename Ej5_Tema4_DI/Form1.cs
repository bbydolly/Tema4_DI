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

namespace Ej5_Tema4_DI
{
    //VALIDACIÓN

    public partial class Form1 : Form
    {

        public static string titulo = "Formulario animadoooo";
        public int cont = titulo.Length - 1;
        string aux = "";
        bool flag = true;
        public Icon icon1;
        public Icon icon2;

        public Form1()
        {
            InitializeComponent();
            toolTip2.SetToolTip(this.listBox2, "Cantidad de elementos en la list box 2: " + listBox2.Items.Count.ToString());
            icon1 = Properties.ResourceImagenes.rayquaza;
            icon2 = Properties.ResourceImagenes.giratina;

        }

        private void btnAbhadir_Click(object sender, EventArgs e)
        {
            ListBox.ObjectCollection lb1 = listBox1.Items;
            if (txtDato.Text != "")
            {
                if (!lb1.Contains(txtDato.Text + "\r\n"))
                {
                    // Debug.Write(false);
                    lb1.Add(txtDato.Text + "\r\n"); //le añado retornos de carro, asique en la comprobación debo incluirlos
                }

            }
            lbElementos.Text = String.Format("Hay {0} elementos en la lista 1", lb1.Count.ToString());
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            ListBox.ObjectCollection lb1 = listBox1.Items;
            ListBox.SelectedObjectCollection elementosSeleccionados = listBox1.SelectedItems;

            //Eliminar elementos de la coleccion count-1 o lenght-1
            for (int i = elementosSeleccionados.Count - 1; i >= 0; i--)
            {
                // Debug.WriteLine("true");
                lb1.Remove(elementosSeleccionados[i]);//elimino el elemento que coincide

            }
            lbElementos.Text = String.Format("Hay {0} elementos en la lista 1", lb1.Count.ToString());

        }

        private void btnTraspasarDerecha_Click(object sender, EventArgs e)
        {
            ListBox.ObjectCollection lb1 = listBox1.Items;
            ListBox.SelectedObjectCollection elementosSeleccionados = listBox1.SelectedItems;

            //Traspaso los elementos en el mismo orden
            for (int i = 0; i < elementosSeleccionados.Count; i++)
            {
                //  Debug.Write("añado a lb2-->" + elementosSeleccionados[i].ToString());
                listBox2.Items.Add(elementosSeleccionados[i]);

            }

            //Elimino los elementos traspasados
            for (int i = elementosSeleccionados.Count - 1; i >= 0; i--)
            {
                // Debug.WriteLine("true");
                lb1.Remove(elementosSeleccionados[i]);//elimino el elemento que coincide

            }
            lbElementos.Text = String.Format("Hay {0} elementos en la lista 1", lb1.Count.ToString());

            // Debug.WriteLine("Cantidad de elementos en listbox2: " + listBox2.Items.Count.ToString());
            toolTip2.SetToolTip(this.listBox2, "Cantidad de elementos en la list box: " + listBox2.Items.Count.ToString() + " elementos.");

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Está perfecto
            lbIndex.Text = "Índices seleccionados:\r\n";
            ListBox.SelectedIndexCollection seleccionados = listBox1.SelectedIndices;
            for (int i = 0; i < seleccionados.Count; i++)
            {
                lbIndex.Text += seleccionados[i] + " , ";

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (flag)
            {
                //Con ruta
                // this.Icon = new Icon("C:\\Users\\Cris\\Downloads\\rayquaza.ico");
                //Como recursos
                /*Para agregar un recurso, sobre Properties agregar archivo, Rec y ya sale, poner el tipo de recurso, seleccionar el archivo
                 y cabiar la configuración */
                //Hace un new cada vez que se ejecuta esto
                //this.Icon = Properties.ResourceImagenes.rayquaza;

                //Recurso definido en el constructor
                this.Icon = icon1;
                flag = false;
            }
            else
            {
                //Como recursos los iconos, en el constructor
                this.Icon = icon2;

                //this.Icon = Properties.ResourceImagenes.giratina;

                //No con rutas
                // this.Icon = new Icon("C:\\Users\\Cris\\Downloads\\giratina.ico");
                flag = true;
            }


            if (cont <= titulo.Length - 1 && cont >= 0)
            {

                // Debug.Write("titulo " + titulo[cont]);
                this.Text = titulo.Substring(cont);//hago el substring desde la posicio del contador hasta el final de la cadena 

                cont--;
            }
            else
            {
                cont = titulo.Length - 1;
            }


        }

        private void btnTraspasarIzquierda_Click(object sender, EventArgs e)
        {
            //No funciona traspasar 
            ListBox.ObjectCollection lb1 = listBox1.Items;

            ListBox.ObjectCollection lb2 = listBox2.Items;
            ListBox.SelectedObjectCollection elementosSeleccionados = listBox2.SelectedItems;

            //Traspaso los elementos en el mismo orden
            for (int i = 0; i < elementosSeleccionados.Count; i++)
            {
                Debug.Write("añado a lb2-->" + elementosSeleccionados[i].ToString());
                listBox1.Items.Add(elementosSeleccionados[i]);

            }

            //Elimino los elementos traspasados
            for (int i = elementosSeleccionados.Count - 1; i >= 0; i--)
            {
                Debug.WriteLine("true");
                lb2.Remove(elementosSeleccionados[i]);//elimino el elemento que coincide

            }
            lbElementos.Text = String.Format("Hay {0} elementos en la lista 1", lb1.Count.ToString());

        }


    }
}
