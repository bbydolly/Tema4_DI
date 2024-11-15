using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej2_tema3_DI
{
    internal class Aula
    {
        public Random x = new Random();



        private int[,] notas;
        public int[,] Notas
        {
            get { return notas; }
            set { notas = value; }
        }



        //Clase indexada(this) es la propia clase-->Aula[n1,n2]
        //Accedo a la nota de la fila y columna del array
        public int this[int f, int c]
        {

            get { return Notas[f, c]; }
        }


        private string[] nombresAlumnos;

        public string[] NombresAlumnos
        {
            get { return nombresAlumnos; }
            set
            {
                nombresAlumnos = value;
                for (int i = 0; i < nombresAlumnos.Length; i++)
                {
                    //guardo cada nombre sin espacios y en mayúsculas
                    nombresAlumnos[i] = nombresAlumnos[i].Trim().ToUpper();
                    //Debug.WriteLine(nombresAlumnos[i]);
                }
            }
        }


        //Sobrecarga al que se le pasa un único string separado por comas
        public Aula(string nombresComas)
        {
            string[] nombres = nombresComas.Split(',');

            //llamo al set y pongo los nombres sin espacios y en mayúsculas
            NombresAlumnos = nombres;

        }



        //Contructor que establece el tamaño de filas y columnas de la matrix
        public Aula(string[] nAlum)
        {

            Notas = new int[nAlum.Length, 4];
            NombresAlumnos = nAlum;



        }

        //Para usar los params por ref, los declaro fuera antes de hacer la llamada a la función
        public void ColocarMaxMin(int index, ref int max, ref int min)
        {
            max = Notas[index, 0];
            min = Notas[index, 0];


            for (int i = 0; i < Notas.GetLength(1); i++)
            {
                if (max < Notas[index, i])
                {
                    max = Notas[index, i];
                }
                if (min > Notas[index, i])
                {
                    min = Notas[index, i];
                }
            }


        }


        public void rellenarNotas()
        {
            int cont = 0;
            //Defino el tamaño de la matriz
            Notas = new int[NombresAlumnos.Length, 4];
            Debug.WriteLine("NombresAlumnos.Lenght---->"+NombresAlumnos.Length);

            for (int i = 0; i < Notas.GetLength(0); i++)//filas
            {
              
                for (int j = 0; j < 4; j++)//columnas
                {
                    Notas[i, j] = x.Next(0, 11);//inicialización del valor
                    Debug.Write(Notas[i, j]+" ");
                }
                Debug.WriteLine("");
              



            }
           

        }


        public double CalcularMedias()
        {
            double acu = 0;
            for (int i = 0; i < Notas.GetLength(0); i++) //FILA
            {
                for (int j = 0; j < Notas.GetLength(1); j++)//COLUMNA
                {
                    acu += Notas[i, j];
                }
            }

            return acu / (Notas.GetLength(0) * Notas.GetLength(1));
        }


        public double MediaAlumno(int fila)//la fila del alumno
        {
            double acu = 0;

            for (int j = 0; j < Notas.GetLength(1); j++)//COLUMNA
            {
                //Debug.Write(Notas[fila, j]);
                acu += Notas[fila, j];
            }

            return acu / 4;
        }

        public double MediaAsignatura(int cons) //hago el cast a int
        {
            double acu = 0;
            for (int i = 0; i < Notas.GetLength(0); i++) //FILA, cantidad de filas
            {
                for (int j = 0; j < Notas.GetLength(1); j++)//COLUMNA, cantidad de columnas
                {
                    acu += Notas[i, cons];
                }
            }
            return acu / Notas.GetLength(0); //cantidad de filas
        }
    }
}
