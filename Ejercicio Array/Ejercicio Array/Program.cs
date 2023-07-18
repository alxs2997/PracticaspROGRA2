using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] par = new int[10];

            for (int i = 0; i < 10; i += 2)
            {
                par[i] = i;
            }
            Console.ReadKey();
        }
    }
}

