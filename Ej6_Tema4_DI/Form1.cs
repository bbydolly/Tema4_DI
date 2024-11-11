using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej6_Tema4_DI
{
    public partial class Form1 : Form
    {
        public Button btn;
        public string[] caracteres = { "*", "0", "#" };
        public int x;
        public int y;
        public Form1()
        {
            //Propiedad text anteponer & para navegacion por nemonicos
            InitializeComponent();
            //PaswordChar, propiedad del txtBox
            Form2 f2=new Form2();
            f2.ShowDialog();    

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
                btn.Click += new System.EventHandler(btns_Click);
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
                btn.Click += new System.EventHandler(btns_Click);
                Controls.Add(btn);
                x += 40;
            }

        }

        private void btns_Click(object sender, EventArgs e)
        {

        }
    }
}
