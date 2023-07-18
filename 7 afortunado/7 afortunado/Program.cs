using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_afortunado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;

            Console.WriteLine("--------------------------");
            Console.WriteLine("__________________________");
            Console.WriteLine("Bienvenido Al 7 Afortunado");
            Console.WriteLine("__________________________");
            Console.WriteLine("--------------------------");
            Console.WriteLine("*********SUERTE***********");
        label:
            Console.Clear();
            int Opcion;
            Random numero = new Random();
            int numero1, numero2, numero3;

            numero1 = numero.Next(1, 8);
            numero2 = numero.Next(1, 8);
            numero3 = numero.Next(1, 8);

            Console.WriteLine("El primer número es; {0}", numero1);
            Console.WriteLine("El segundo número es; {0}", numero2);
            Console.WriteLine("El tercer número es; {0}", numero3);

            if ((numero1 == 7) && (numero2 == 7) && (numero3 == 7))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("FELICIDADES!!!!!!! \n HAS GANADO!!!!!!!!!!!!!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("PERDISTE :( \n MEJOR SUERTE A LA PROXIMA");
                }

            Console.WriteLine("¿Desea Intentarlo de nuevo? \n 1---> SI");
            Opcion = int.Parse(Console.ReadLine());
            if (Opcion == 1) {
                goto label;
            }
            else if (Opcion == 2) {
                Console.ReadKey();
            }
                
              
            } 
                

            

                

            }

        }
            


           
        
    

