using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio
{
    class Program
    {
        static void Main(string[] args)
        {
            label:
            string UGB = ""; string Ap = ""; string Re = "";
            

            Console.BufferHeight = 800;
            Console.BufferWidth = 1000;
            
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine(UGBArt.UGB(UGB));

            double total = 0;
            Console.Write("\n\n\n\t\t\t\t\t\t\t\t\tDIGITE NOTA DEL 1° LABORATORIO: ");
            double L1 = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine(UGBArt.UGB(UGB));
            Console.Write("\n\n\n\t\t\t\t\t\t\t\t\tDIGITE NOTA DEL 2° LABORATORIO: ");
            double L2 = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine(UGBArt.UGB(UGB));
            Console.Write("\n\n\n\t\t\t\t\t\t\t\t\tDIGITE NOTA DEL PARCIAL: ");
            double parcial = double.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine(UGBArt.UGB(UGB));
            Console.Write("\n\n\n\t\t\t\t\t\t\t\t\tPROMEDIO TOTAL: {0}\n", Program.promedio(L1, L2, parcial, total));
            total = Program.promedio(L1, L2, parcial, total);
            if (total >= 7)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(UGBArt.APROBADO(Ap));
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(UGBArt.REPROBADO(Re));
            }

            Console.ForegroundColor = ConsoleColor.Black; Console.Write("\n\n\n\t\t\t\t\t\t\t\tPRESIONE "); Console.ForegroundColor = ConsoleColor.Blue; Console.Write("END"); Console.ForegroundColor = ConsoleColor.Black; Console.Write(" PARA SALIR");
            Console.ForegroundColor = ConsoleColor.Black; Console.Write("\n\n\t\t\t\t\t\t\t\tPRESIONE "); Console.ForegroundColor = ConsoleColor.Blue; Console.Write("H"); Console.ForegroundColor = ConsoleColor.Black; Console.WriteLine(" PARA HACER NUEVA CONSULTA");
            if (Console.ReadKey().Key != ConsoleKey.H)
            {
                while (Console.ReadKey().Key != ConsoleKey.End);
            }
            else
            {
                goto label;
            }
            
            
            
            
            
            
            
            
        }
        public static double promedio (double x, double y, double z, double total)
        {
            return total = (x * 0.3 + y * 0.3) + (z * 0.4);
        }
    }
}
