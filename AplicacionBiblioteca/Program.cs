using System;
using System.Collections.Generic;
using ClassLibrary1;

namespace AplicacionBiblioteca
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Por favor introduce cinco numeros:");
            int[] array = new int[5];
            int numero;
            for (int i=0; i<5; i++)
            {
                numero = int.Parse(Console.ReadLine());
                array[i] = numero;
            }

            //con Ciclos.cs
            int res1 = Ciclos.SumaV(array);
            double res2 = Ciclos.MultV(array);
            int res3 = Ciclos.Potencia(array[1],3);
            int res4 = Ciclos.Factorial(array[1]);

            Console.WriteLine("La suma de tus numeros es: "+res1);
            Console.WriteLine("La multiplicación de tus numeros es: "+res2);
            Console.WriteLine("El número {0} ingresado elevado al cubo es igual a: {1}", array[0], res3);
            Console.WriteLine("El factorial del número {0} ingresado es igual a: {1}", array[1], res4);


            //con Numeros.cs
            Console.WriteLine("Se ingresa el número 15.6321.");
            string cadena = "15.6321";
            int res5 = Numeros.Entero(cadena);
            float res6 = Numeros.Flotante(cadena);

            Console.WriteLine("La conversión a entero es: "+res5);
            Console.WriteLine("La conversión a flotante es: "+res6);
        }
    }
}
