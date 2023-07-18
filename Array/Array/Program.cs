using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
          
            
            int[] n = new int[10];

            for (int i = 0; i < 10; i++)
            {
                n[i] = i + 255;
            }

            foreach (int j in n)
            {
                Console.WriteLine("{0} ", j);

            }
            Console.ReadKey();

        }
    }
}
