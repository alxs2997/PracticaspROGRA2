using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vocal__if_
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch;
            Console.Write("Ingresa un Caracter: \t");
            ch = Convert.ToChar(Console.ReadLine());

            if (ch == 'a' || ch == 'A' || ch == 'e' || ch == 'E' || ch == 'i' || ch == 'I' || ch == 'o' || ch == 'O' || ch == 'u' || ch == 'U')

            { Console.WriteLine("\n\n{0} es una vocal", ch); }

            else

            { Console.WriteLine("\n\n{0} no es vocal", ch); }
            Console.ReadLine();
        }
    }
}

    

