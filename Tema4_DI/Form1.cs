using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema4_DI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            // Point p = e.Location;
            //Desde e--> e.X e.Y
            this.Text = "X: "+e.X.ToString() +" Y: " +e.Y.ToString(); //devuelve x e y
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            this.Text= "Mouse Tester";
        }

       

        //Todo gestión de click con el mouse
        private void Mouse_Click_botones(object sender, MouseEventArgs e)
        {
            if (e.Button==Button.MouseButtons)
            {
                button1.BackColor = Color.Turquoise;
            }
            else if ((Button)sender == button2)
            {
                button2.BackColor = Color.Yellow;
            }
        }
    }
}
