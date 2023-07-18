using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Tercera_Semana
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = null;
            string apellido = null;
            string Letra1 = null;
            string letra2 = null;
            int año;
            Console.WriteLine("Escriba El Primer Nombre del Estudiante");
            nombre = Console.ReadLine();
            Letra1 = nombre.Substring(0, 1);

            Console.WriteLine("Escriba El Primer Apellido del Estudiante");
            apellido = Console.ReadLine();
            letra2 = apellido.Substring(0, 1);

            Console.WriteLine("Escriba El Primer Apellido del Estudiante");
            año = int.Parse(Console.ReadLine());

            Console.WriteLine("Tu codigo es {0}{1}{2}", Letra1.ToString(),letra2.ToString(), año);


            Console.ReadKey();

        }
        }
    }

