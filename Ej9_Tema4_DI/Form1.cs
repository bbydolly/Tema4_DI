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

namespace Ej9_Tema4_DI
{
    //Es un MenuStrip , a la derecha en una flechita>clicar>Añadir elementos estandar
    public partial class Form1 : Form
    {


        SaveFileDialog saveFileDialog;
        public Form1()
        {
            InitializeComponent();
            this.txtEditor.Size = this.ClientSize;
            this.Text = "*Sin título: Bloc de notas";
            txtEditor.BorderStyle = BorderStyle.None;
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtEditor.Text.Length > 0)
            {
                //desea guardar??
                if (MessageBox.Show("¿Quieres guardar los cambios de ?" + this.Text, "Bloc de notas",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    saveFileDialog = new SaveFileDialog();
                    DialogResult ok = saveFileDialog.ShowDialog();

                    if (ok == DialogResult.OK)
                    {
                        
                        //GUARDO EL ARCHIVO
                        Save_File(saveFileDialog.FileName);//Obtengo la ruta


                    }



                }
                else
                {
                    txtEditor.Text = "";
                }

            }
           
           // Form1 f1 = new Form1();
        }


        public void Save_File(String path)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {

                sw.WriteLine(txtEditor.Text);

                sw.Flush();

                txtEditor.Text = "";

            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            txtEditor.Size = this.ClientSize;   
        }

        private void ajusteDeLíneaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            txtEditor.WordWrap = !txtEditor.WordWrap;
        }
    }
}
