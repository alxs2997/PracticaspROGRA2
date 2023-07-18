using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dias_de_Semana__Array_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] week = new string[7]; // Se crea el Array

            week[0] = "Sunday"; // Se asigna a la pos 0 Sunday
            week[1] = "Monday"; // Se asigna a la pos 1 Monday
            week[2] = "Tuesday"; // Se asigna a la pos 2 Tuesday
            week[3] = "Wednsday"; // Se asigna a la pos 3 Wednsday
            week[4] = "Thursday"; // Se asigna a la pos 4 Thursday
            week[5] = "friday"; // Se asigna a la pos 5 Friday
            week[6] = "Saturday"; // Se asigna a la pos 6 Saturday
            
            // Inicia lectura del for
            for (int i = 0; i <= week.Length - 1; i++)
            {

                Console.WriteLine(week[i]);
              

            }
            Console.ReadKey();

        }
    }
}




