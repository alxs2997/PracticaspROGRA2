using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tercera_semana
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Math.Sqrt(25));
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Math.Max(5, 7));
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(Math.Min(5, 7));
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(Math.Pow(4, 3));

            DirectoryInfo di = new DirectoryInfo(@"C:\Users\Alexander Ordoñez\Desktop\Nueva Carpeta");
            Console.WriteLine("No se encontraron archivos....");
            foreach (var fi in di.GetFiles())
            {
                Console.WriteLine(fi.Name);
                fi.Delete();
                
            }
            
            Console.ReadKey();
        }
    }
}
