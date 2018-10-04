using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary1
{
    public class Cadenas
    {
        public static void Imprimir(TextBox t1)
        {
            t1.Text = "Hola";

        }
        public static void Identificar(string s1)
        {
            if (s1 == null )
            {
                MessageBox.Show("No se introdujo nada");
            }
            if (s1 == "")
            {
                MessageBox.Show("No se introdujo nada");
            }
        }
        public static void Cabecera()
        {
            MessageBox.Show("Erick Mercado Santoyo\n20 de septiembre de 2018");
        }
    }
}
