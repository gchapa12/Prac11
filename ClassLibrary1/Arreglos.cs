using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ClassLibrary1
{
    public class Arreglos
    {
        public static int[] GVEnt(string S1)
        {
            string[] vectorcadena = S1.Split(',');
            int dimension = vectorcadena.Length;
            int[] vector = new int[dimension];
            for(int i = 0; i < dimension; i++)
            {
                vector[i] = Numeros.Entero(vectorcadena[i]);

            }
            return vector;
        }
        public static void IVEnt(int[] vector,TextBox t1)
        {
            int dimension = vector.Length;
            string S = "[";
            int i=0;
            for (i = 0; i < dimension-1; i++)
            {
                S = S + Convert.ToString(vector[i]) + ",";
            }
            S = S + Convert.ToString(vector[dimension-1]) + "]";
            t1.Text = S;
        }
        public static float[] GVFloat(string S1)
        {
            string[] vectorcadena = S1.Split(',');
            int dimension = vectorcadena.Length;
            float[] vector = new float[dimension];
            for (int i = 0; i < dimension; i++)
            {
                vector[i] = Numeros.Flotante(vectorcadena[i]);

            }
            return vector;
        }
        public static void IVFloat  (float[] vector, TextBox t1)
        {
            int dimension = vector.Length;
            string S = "[";
            int i = 0;
            for (i = 0; i < dimension - 1; i++)
            {
                S = S + Convert.ToString(vector[i]) + ",";
            }
            S = S + Convert.ToString(vector[dimension - 1]) + "]";
            t1.Text = S;
        }
        public static string[] GVstring(string S1)
        {
            string[] vectorcadena = S1.Split(',');
            
            return vectorcadena;
        }
        public static void IVstring(string[] vector, TextBox t1)
        {
            int dimension = vector.Length;
            string S = "[";
            int i = 0;
            for (i = 0; i < dimension - 1; i++)
            {
                S = S + vector[i] + ","; 
            }
            S = S + vector[dimension - 1] + "]";
            t1.Text = S;
        }
        public static int[,] GMEnt(string S1)
        {
            int i, j, k = 0;
            string[] fila = S1.Split(';');
            string[] Columna = fila[0].Split(',');
            string[] v = S1.Split(',', ';');
            int[,] M1 = new int[fila.Length, Columna.Length];
            for (i = 0; i < fila.Length; i++)
            {
                for (j = 0; j < Columna.Length; j++)
                {
                    M1[i, j] = Numeros.Entero(v[k]);                  
                    k++;
                }
            }
            return M1;
        }
        public static void IMEnt(int[,] Matriz, TextBox t1)
        {
            int i, j;
            
            for (i = 0; i < Matriz.GetLength(0); i++)
            {
                t1.Text += "|";
                for (j = 0; j < Matriz.GetLength(1); j++)
                {
                    if (j != Matriz.GetLength(1) - 1)
                    {
                        t1.Text += Matriz[i, j].ToString() + " , ";
                    }
                    else
                    {
                        t1.Text += Matriz[i, j].ToString();
                    }


                }
                t1.Text += "|"+Environment.NewLine; 


            }
        }
        public static float[,] GMflotante(string S1)
        {
            int i, j, k = 0;
            string[] fila = S1.Split(';');
            string[] Columna = fila[0].Split(',');
            string[] v = S1.Split(',', ';');
            float[,] M1 = new float[fila.Length, Columna.Length];
            for (i = 0; i < fila.Length; i++)
            {
                for (j = 0; j < Columna.Length; j++)
                {
                    M1[i, j] = Numeros.Flotante(v[k]);
                    k++;
                }
            }
            return M1;
        }
        public static void IMflotante(float[,] Matriz, TextBox t1)
        {
            int i, j;

            for (i = 0; i < Matriz.GetLength(0); i++)
            {
                t1.Text += "|";
                for (j = 0; j < Matriz.GetLength(1); j++)
                {
                    if (j != Matriz.GetLength(1) - 1)
                    {
                        t1.Text += Matriz[i, j].ToString() + " , ";
                    }
                    else
                    {
                        t1.Text += Matriz[i, j].ToString();
                    }


                }
                t1.Text += "|" + Environment.NewLine;


            }
        }

    }
}
