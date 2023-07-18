using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace length
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = null;
            Console.WriteLine("Escribe tu nombre ");
            nombre = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Tu nombre {0} Tiene {1} letras", nombre, nombre.Length);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ejercicio Substring");
            string str = null;
            string retString = null;
            str = "This is substring test";
            retString = str.Substring(5, 2);

            Console.WriteLine(retString.ToString());
            Console.ReadKey();
        }
    }
}
