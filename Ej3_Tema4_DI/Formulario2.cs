using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej3_Tema4_DI
{
    //Icono y título
    public partial class Formulario2 : Form
    {
        public Formulario2(string nombreArchivo)
        {
            InitializeComponent();
            this.Text = nombreArchivo;
        }

        //Cuando se cambia de tamaño el formulario
        private void Formulario2_Resize(object sender, EventArgs e)
        {

            int anc = this.ClientSize.Width;
            int alt = this.ClientSize.Height;


            pictureBox1.Size = new Size(anc, alt);
        }
    }
}
