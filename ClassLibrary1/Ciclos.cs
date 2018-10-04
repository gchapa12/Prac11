using System;

namespace ClassLibrary1
{
    public class Ciclos
    {
        //1
        public static int SumaV(int[] v)
        {
            int suma=0;
            for(int i = 0; i < v.Length; i++)
            {
                suma += v[i];
            }
            return suma;
        }
        //2
        public static int MultV(int[] v)
        {
            int suma = 0;
            for (int i = 0; i < v.Length; i++)
            {
                suma *= v[i];
            }
            return suma;
        }

        //4
        public static int Fibonacci(int n)
        {
            int a=1, b=-1, c=0;
            for(int i = 0; i < n; i++)
            {
                c = a+b;
                b=a;
                a = c;
            }
            return c;
        }
        //5
        public static int Factorial(int a)
        {
            int factorial=1;
            for(int i =a-1; i >-1; i--)
            {
                factorial = factorial * (a - i);
            }
            return factorial;
        }
        //6
        public static int Potencia(int a,int b)
        {
            int potencia = 1;
            for(int i = 0; i < b; i++)
            {
                potencia *= a;
            }
            return potencia;
        }
        public static string Mayusculas(string s1)
        {
            char[] v = s1.ToCharArray();
            string cadena="";
            int a;
            for(int i = 0; i < v.Length; i++)
            {
                a = Convert.ToInt16(v[i]);
                if (a >= 97 && a <= 122)
                {
                    a = a - 32;
                    v[i] = Convert.ToChar(a);
                }
 
                cadena = cadena + v[i];
            }
            return cadena;

        }
        public static string Minusculas(string s1)
        {
            char[] v = s1.ToCharArray();
            string cadena = "";
            int a;
            for (int i = 0; i < v.Length; i++)
            {
                a = Convert.ToInt16(v[i]);
                if (a >= 65 && a <= 90)
                {
                    a = a +32;
                    v[i] = Convert.ToChar(a);
                }

                cadena = cadena + v[i];
            }
            return cadena;

        }
    }
}
