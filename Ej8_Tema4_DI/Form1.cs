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


//TODO pendiente de validación

namespace Ej8_Tema4_DI
{
    //sizemode. zoom
    //jpg, png
    //array de extensiones

    //TODO botones avance y retroceso, cargar imágenes
    public partial class Form1 : Form
    {
        FolderBrowserDialog folderBrowserDialog;
        String pathCarpeta;
        PictureBox pictureBox;
        //Clase bitmap 
        String[] extensiones = { ".bmp", ".gif", ".exif", ".jpg", ".png", ".tiff" };
        FileInfo[] archivosExtension;
        int cont = 0;
        Form2 f2;
        DirectoryInfo directoryInfo;
        FileInfo[] archivos;
        Boolean flag = false;
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TODO filtro para que salgan las carpetas a las que el usuario tiene permiso 
            folderBrowserDialog = new FolderBrowserDialog();
            DialogResult res = folderBrowserDialog.ShowDialog();

            switch (res)
            {

                case DialogResult.OK:
                    pathCarpeta = folderBrowserDialog.SelectedPath;
                    Debug.Write(pathCarpeta);
                    addImagenes(pathCarpeta);
                    //folderBrowserDialog.ope
                    break;
                case DialogResult.Cancel:

                    break;

            }
        }

        public void addImagenes(String pathCarpeta)
        {
            int x = 0;
            int y = 14;
            try
            {
                directoryInfo = new DirectoryInfo(pathCarpeta);
                archivos = directoryInfo.GetFiles();
                archivosExtension = Array.FindAll(archivos, a => extensiones.Contains(a.Extension));
                flag = true;


                //try chatch gestion de permisos etc 
                this.Size = new Size(64 * 8, ((archivosExtension.Length / 7) * 64) + 94);
                panel1.Size = new Size(7 * 64, (archivosExtension.Length / 7) * 64);

                try
                {


                    f2 = new Form2(archivosExtension[0].FullName, this);
                    f2.Show();


                    for (int i = 0; i < archivosExtension.Length; i++)
                    {
                        //Debug.WriteLine("archivo " + i + " "+archivosExtension[i]);
                        pictureBox = new PictureBox();
                        try
                        {
                            Debug.WriteLine(archivosExtension[i].FullName);
                            pictureBox.Image = new Bitmap(archivosExtension[i].FullName);//Image.FromFile(archivosExtension[i].ToString());
                            pictureBox.Tag = archivosExtension[i].FullName;
                            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                            pictureBox.BorderStyle = BorderStyle.None;
                            pictureBox.Size = new Size(64, 64); //distribuir en 7 columnas


                            if (i % 7 == 0)
                            {
                                //cambio de línea
                                Debug.WriteLine("divisible 7");
                                if (i != 0)
                                {

                                    x = 0;
                                    y += 64;
                                }
                            }
                            else
                            {
                                if (i != 0)
                                {

                                    x += 65;
                                }

                            }
                            pictureBox.Location = new Point(x, y);

                            pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
                            panel1.Controls.Add(pictureBox);
                            this.ClientSize = new Size(panel1.Width + 20, panel1.Height + 180);
                            ToolStripItemCollection c = contextMenuStrip1.Items;
                            foreach (ToolStripItem item in c)
                            {
                                item.Enabled = true;
                            }
                        }
                        catch (FileNotFoundException e)
                        {
                            Debug.WriteLine("filenotfound    " + archivosExtension[i].ToString());
                            //elimina los archivos corruptos
                        }
                        lblInfo.Text = "Directorio de trabajo: " + directoryInfo.Name;



                    }
                }
                catch (IndexOutOfRangeException i)
                {

                    Debug.WriteLine("Índice fuera de los límites de la matriz");
                    //lblInformativa.ForeColor = Color.Red;
                    //lblInformativa.Text = "Índice fuera de los límites de la matriz";
                }
            }
            catch (UnauthorizedAccessException u)
            {
                Debug.WriteLine("No estás autorizado a acceder a la carpeta seleccionada");
            }


        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Clico en un pictureBox" + ((PictureBox)sender).Tag);
            //f2.Avance(((PictureBox)sender).Tag.ToString());
            f2.Avance_Retroceso(((PictureBox)sender).Tag.ToString());
        }

        private void btnRetroceso_Click(object sender, EventArgs e)
        {
            if (flag)
            {

                cont--;
                if (cont >= 0 && cont <= archivosExtension.Length - 1)
                {
                    //f2.Retroceso(archivosExtension[cont].FullName);
                }
                else
                {
                    cont = archivosExtension.Length - 1;
                    // f2.Retroceso(archivosExtension[cont].FullName);
                }
                f2.Avance_Retroceso(archivosExtension[cont].FullName);
            }

        }

        private void btnAvance_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                cont++;
                if (cont <= archivosExtension.Length - 1 && cont >= 0)
                {
                    //  f2.Avance(archivosExtension[cont].FullName);
                }
                else
                {
                    cont = 0;
                    //f2.Avance(archivosExtension[cont].FullName);
                }
                f2.Avance_Retroceso(archivosExtension[cont].FullName);
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)//avance
            {
                btnRetroceso_Click(sender, e);
            }
            else if (e.KeyCode == Keys.Right)//retroceso
            {
                //menú contextual


                btnAvance_Click(sender, e);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea salir de la aplicación?", "Visor de imágenes", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;//Cancelo el cierre del formulario
            }
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}
