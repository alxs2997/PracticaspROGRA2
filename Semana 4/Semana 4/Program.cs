using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe el Primer Numero");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe el Segundo Numero");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("La suma es {0}", Program.suma(n1, n2));
            Console.ReadKey();
        }
        public static int suma(int x, int z)
        {
            return x + z ;
        }

    }
}
