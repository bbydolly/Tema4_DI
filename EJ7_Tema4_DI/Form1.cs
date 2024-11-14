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

namespace EJ7_Tema4_DI
{
    public partial class Form1 : Form
    {
        string ruta = "C:\\Users\\Cris\\Desktop\\nombres.txt";
        string names;
        public Form1()
        {
            InitializeComponent();
            //lEO UN ARCHIVO CON NOMBRES DE ALUMNO SEPARADOS POR COMAS Y SE LO PASO AL CONSTRUCTOR DE AULA
            if (File.Exists(ruta)){
                Debug.WriteLine("Existeee");
                using (StreamReader tr = new StreamReader(ruta))
                {
                    names = tr.ReadToEnd();
                    Debug.WriteLine(names);


                    if (names.Length > 0)
                    {
                        Aula aula = new Aula(names);
                        string[] nAlumnos = aula.NombresAlumnos;

                        foreach (string s in nAlumnos)
                        {
                            cbAlumnos.Items.Add(s);
                        }
                    }

                    //Cojo el enumerado y lo recorro 
                   string[] asignaturas=Enum.GetNames(typeof(Asignaturas));

                    foreach (string s in asignaturas)
                    {
                        cbAsignaturas.Items.Add(s);
                    }
                   
                }
            }
        }
    }
}
