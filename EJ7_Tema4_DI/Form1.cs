using Ej2_tema3_DI;
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


//Pendiente de VALIDACIÓN, correcciones hechas

//Si dejas los combos editables que sean para hacer búsqueda, si no que no se puedan editar.
//Ruta absoluta del archivo (debes usar variable de entorno)
//No debes usar MOuseHover, es MouseEnter
//Falta info de máximo y mínimo.

namespace EJ7_Tema4_DI
{

    //Drop down style-->drop down list para no dejar que el usuario seleccione

    public partial class Form1 : Form
    {
        string ruta = Environment.ExpandEnvironmentVariables("%USERPROFILE%") + "\\nombres.txt";
        string names;
        public int[,] notas;

        public Form1()
        {
            InitializeComponent();
            Label lb;
            //lEO UN ARCHIVO CON NOMBRES DE ALUMNO SEPARADOS POR COMAS Y SE LO PASO AL CONSTRUCTOR DE AULA
            Aula aula;
            if (File.Exists(ruta))
            {
                //Debug.WriteLine("Existeee");
                int x = 40;
                int y = 100;

                using (StreamReader tr = new StreamReader(ruta))
                {
                    names = tr.ReadToEnd();
                    Debug.WriteLine(names);

                    aula = new Aula(names);
                    string[] nAlumnos = aula.NombresAlumnos;

                    if (names.Length > 0)
                    {

                        foreach (string s in nAlumnos)
                        {
                            cbAlumnos.Items.Add(s);
                            //cbAlumnos.SelectedIndexChanged += SelectedIndexChanged;

                            //Labels nombres alumnos
                            lb = new Label();
                            lb.Text = s;
                            lb.Font = new Font("Arial", 10, FontStyle.Regular);
                            lb.Size = new Size(50, 20);
                            lb.Location = new System.Drawing.Point(x, y);
                            Controls.Add(lb);
                            y += 30;

                        }
                    }

                    //Cojo el enumerado y lo recorro 
                    string[] asignaturas = Enum.GetNames(typeof(Asignaturas));

                    x = 150;
                    y = 60;
                    foreach (string s in asignaturas)
                    {
                        cbAsignaturas.Items.Add(s);
                        lb = new Label();
                        lb.Text = s;
                        lb.Font = new Font("Arial", 10, FontStyle.Regular);
                        lb.Size = new Size(90, 20);
                        lb.Location = new System.Drawing.Point(x, y);
                        Controls.Add(lb);
                        x += 90;
                    }

                    //La tabla se mantiene siempre con nombres, asignaturas y las
                    //notas
                    aula.rellenarNotas();
                    notas = aula.Notas;


                    x = 150;
                    y = 100;
                    ToolTip tt = new ToolTip();

                    String alumno = "";
                    string asignatura = "";
                    //Nombre del alumno
                    for (int i = 0; i < notas.GetLength(0); i++)
                    {
                        //Debug.WriteLine(notas.GetLength(0));


                        for (int j = 0; j < notas.GetLength(1); j++)
                        {
                            alumno = nAlumnos[i];
                            //Debug.WriteLine(notas.GetLength(1));

                            //Nombre
                            asignatura = asignaturas[j];
                            lb = new Label();
                            lb.Text = notas[i, j].ToString();
                            lb.Font = new Font("Arial", 10, FontStyle.Regular);
                            tt.SetToolTip(lb, "Asignatura: " + asignatura + "\nAlumno: " + alumno);
                            lb.Size = new Size(90, 20);
                            lb.Font = new Font("Arial", 10, FontStyle.Regular);
                            lb.Location = new System.Drawing.Point(x, y);
                            lb.MouseEnter += MouseEnter;
                            lb.MouseLeave += MouseLeave;
                            Controls.Add(lb);
                            x += 90;

                        }

                        // alumno = nAlumnos[i];
                        y += 30;
                        x = 150;




                    }
                    lb = new Label();
                    lb.Name = "lbInfo";
                    lb.Text = "Media de toda la tabla: " + aula.CalcularMedias();
                    Debug.WriteLine(aula.CalcularMedias());
                    lb.Font = new Font("Arial", 10, FontStyle.Regular);
                    tt.SetToolTip(lb, "Media de la asignatura: ");//+media de notas del alumno seleccionado y media de notas de una asignatura
                    lb.Size = new Size(290, 20);
                    lb.Location = new System.Drawing.Point(30, 410);
                    Controls.Add(lb);


                }
            }
        }



        public void MouseEnter(object c, EventArgs a)
        {
            Color fondo = ((Label)c).ForeColor;
            //Especificación en amarillo
            ((Label)c).BackColor = Color.Yellow;

            //* Ampliación 
            //*
            int n = Convert.ToInt32(((Label)c).Text);
            Label cc = ((Label)c);

            //if (n < 5)
            //{
            //    cc.BackColor = Color.Red;
            //}
            //else if (n >= 5 && n<=8)
            //{
            //    cc.BackColor = Color.Yellow;

            //}
            //else 
            //{
            //    cc.BackColor = Color.Green;
            //}
            cc.BackColor = n < 5 ? cc.BackColor = Color.Red : n <= 8 ? cc.BackColor = Color.Yellow : cc.BackColor = Color.Green;

        }

        public void MouseLeave(object c, EventArgs a)
        {
            ((Label)c).BackColor = Label.DefaultBackColor;
        }



        private void cbAlumnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            double acu = 0;
            for (int i = 0; i < notas.GetLength(0); i++)
            {
                for (int j = 0; j < notas.GetLength(1); j++)
                {

                    acu += notas[cbAlumnos.SelectedIndex, j];
                }

            }

            // lbAlumno.Font= new Font("Arial", 10, FontStyle.Regular);
            lbAlumno.Text = "Media de las notas de " + cbAlumnos.SelectedItem + " es " + (acu / notas.Length).ToString();
            //Nota máxima y mínima 

            NotaMaxMin(cbAlumnos.SelectedIndex);

        }

        private void cbAsignaturas_SelectedIndexChanged(object sender, EventArgs e)
        {
            double acu = 0;
            for (int i = 0; i < notas.GetLength(0); i++)
            {

                acu += notas[i, cbAsignaturas.SelectedIndex];


            }
            // lbMediaNotas.Font= new Font("Arial", 10, FontStyle.Regular);
            lbMediaNotas.Text = "Media de la asignatura de " + cbAsignaturas.SelectedItem + " es " + (acu / notas.GetLength(0)).ToString();
        }

        public void NotaMaxMin(int indexAlumno)
        {
            int max = notas[indexAlumno, 0];
            int min = notas[indexAlumno, 1];

            // int valorMin = 0;
            //int valorMax = 0;

            for (int i = 0; i < notas.GetLength(0); i++)
            {
                for (int j = 0; j < notas.GetLength(1); j++)
                {
                    if (max < notas[indexAlumno, j])
                    {
                        max = notas[indexAlumno, j];
                    }

                    if (min > notas[indexAlumno, j])
                    {
                        min = notas[indexAlumno, j];
                    }
                }
            }
            lbAlumno.Text +=  "\r\nNota mínima: " + min + "\r\nNota max: " + max;


        }


    }
}
