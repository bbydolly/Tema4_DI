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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            ListBox.ObjectCollection lb1 = listBox1.Items;
            ListBox.SelectedObjectCollection elementosSeleccionados = listBox1.SelectedItems;
            //Me quita de uno en uno 
            Debug.WriteLine("elementos seleccionados " + elementosSeleccionados.Count);

            //TODO revisar eliminacion de la lista
            for (int i = elementosSeleccionados.Count; i
                
                > 0; i--)
            {
                if (lb1.Contains(elementosSeleccionados[i]))
                {
                    Debug.WriteLine("true");
                    lb1.Remove(elementosSeleccionados[i]);//elimino el elemento que coincide
                }
            }


            //ListBox.SelectedIndexCollection elementosSeleccionados = listBox1.SelectedIndices; //elementos seleccionados
            //for (int i = 0; i < elementosSeleccionados.Count; i++)
            //{
            //   // lb1.Remove(listBox1.ite(elementosSeleccionados[i]));
            //   lb1.
            //}
        }
    }
}
