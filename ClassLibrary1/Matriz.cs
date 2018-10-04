using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Matriz
    {
        public int n;
        public int[,] Matrices;

        public Matriz(int m)

        {
            n = m;
            Matrices = new int[n, n];


        }
        public static Matriz operator +(Matriz m1, Matriz m2)
        {
            int i, j;
            Matriz M = new Matriz(m1.n);
            for (i = 0; i < m1.n; i++)
            {
                for (j = 0; j < m1.n; j++)
                {
                    M.Matrices[i, j] = m1.Matrices[i, j] + m2.Matrices[i, j];
                }
            }

            return M;
        }
        public static Matriz operator -(Matriz m1, Matriz m2)
        {
            int i, j;
            Matriz M = new Matriz(m1.n);
            for (i = 0; i < m1.n; i++)
            {
                for (j = 0; j < m1.n; j++)
                {
                    M.Matrices[i, j] = m1.Matrices[i, j] - m2.Matrices[i, j];
                }
            }

            return M;
        }
        public static Matriz operator *(Matriz m1, Matriz m2)
        {
            int i, j, k;
            Matriz M = new Matriz(m1.n);
            for (i = 0; i < m1.n; i++)
            {
                for (j = 0; j < m1.n; j++)
                {
                    for (k = 0; k < m1.n; k++)
                    {
                        M.Matrices[i, j] = M.Matrices[i, j] + (m1.Matrices[i, k] * m2.Matrices[k, j]);

                    }

                }
            }

            return M;
        }
    }
}
