using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ClassLibrary1
{
    public class Numeros
    {
        public static int Entero(string cadena)
        {
            int num = 0;
            try
            {
                num = Convert.ToInt32(cadena);
            }
            catch
            {
                MessageBox.Show("El formato no se puede convertir");

            }
            return num;
        }
        public static float Flotante(string cadena)
        {
            float num = 0;
            try
            {
                num = Convert.ToSingle(cadena);
            }
            catch
            {
                MessageBox.Show("El formato no se puede convertir");

            }
            return num;
        }
    }
}
