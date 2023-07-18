using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amigos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Nombres = new string[5];
            Nombres[0] = "Juan David";
            Nombres[1] = "Raul Ernesto";
            Nombres[2] = "Cesar Zelada";
            Nombres[3] = "Yoselyn Mergar";
            Nombres[4] = "Marlon Segovia";

            for (int i = 0; i <= Nombres.Length - 1; i++)
            {
                Console.WriteLine(Nombres[i]);

            }
            Array.Sort(Nombres);
            Array.Reverse(Nombres);
            Console.WriteLine(Nombres);
            Console.ReadKey();
            
        } 
        
    }

}
