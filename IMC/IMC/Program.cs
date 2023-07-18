using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Title = "Calculadora de IMC";



            Console.WriteLine("*********************************************");
            Console.WriteLine("* Calculadora del IMC                       *");
            Console.WriteLine("* Programador: Alexander José Ordoñez Pérez *");
            Console.WriteLine("*********************************************");

            int opcion;
            double Peso, Altura, IMC;
            Console.WriteLine("¿Como Desea Ingresar su Peso?");
            Console.WriteLine("1---> Libras");
            Console.WriteLine("2---> Kilogramos");
            Console.WriteLine("Escriba su Opcion:");
            opcion = int.Parse(Console.ReadLine());

            // libras
            if (opcion == 1) {
                Console.WriteLine("Seleccionaste Libras");
                Console.WriteLine("Ingrese Su Peso en Libras");
                Peso = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese Su Estatura en Metros");
                Altura = double.Parse(Console.ReadLine());
                IMC = (Peso / 2.2) / (Altura * Altura);
                if (IMC <=16.0) {
                    Console.WriteLine("Infrapeso: Delgadez Severa");
                }  if ((IMC > 16.0) && (IMC <= 16.99)) { 
                    Console.WriteLine("Infrapeso: Delgadez Moderada");
                }  else if ((IMC>=17.00) && (IMC<=18.49)) {
                    Console.WriteLine("Infrapeso: Delgadez Aceptable");
                } else if ((IMC>=18.50) && (IMC<=24.99)) {
                    Console.WriteLine("Peso Normal");
                } else if  ((IMC>=25.00) && (IMC<=29.99)) {
                    Console.WriteLine("Sobrepeso");
                } else if ((IMC>=30.00) && (IMC <= 34.99)) {
                    Console.WriteLine("Obeso: Tipo I");
                } else if ((IMC>=35.00) && (IMC <= 40.00)) {
                    Console.WriteLine("Obeso: Tipo II");
                } else if (IMC > 40.00) {
                    Console.WriteLine("Obeso: Tipo III");
                }
            }



            // Kilogramos
            else if (opcion == 2) {
                Console.WriteLine("Seleccionaste Kilogramos");
                Console.WriteLine("Ingrese Su Peso en Kilogramos");
                Peso = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese Su Estatura en Metros");
                Altura = double.Parse(Console.ReadLine());
                IMC = Peso / (Altura * Altura);
                if (IMC <= 16.0) {
                    Console.WriteLine("Infrapeso: Delgadez Severa");
                } if ((IMC > 16.0) && (IMC <= 16.99)) {
                    Console.WriteLine("Infrapeso: Delgadez Moderada");
                } else if ((IMC >= 17.00) && (IMC <= 18.49)) {
                    Console.WriteLine("Infrapeso: Delgadez Aceptable");
                } else if ((IMC >= 18.50) && (IMC <= 24.99)) {
                    Console.WriteLine("Peso Normal");
                } else if ((IMC >= 25.00) && (IMC <= 29.99)) {
                    Console.WriteLine("Sobrepeso");
                } else if ((IMC >= 30.00) && (IMC <= 34.99)) {
                    Console.WriteLine("Obeso: Tipo I");
                } else if ((IMC >= 35.00) && (IMC <= 40.00)) {
                    Console.WriteLine("Obeso: Tipo II");
                } else if (IMC > 40.00) {
                    Console.WriteLine("Obeso: Tipo III");
                }
            }

            // Otra Opcion
            else {
                Console.WriteLine("Por Favor Digita una Opcion Valida");
                Console.WriteLine("¿Desea realizar otro calculo?");
                Console.WriteLine("1---> SI");
                Console.WriteLine("2---> NO");
                
            }
            
            

            Console.ReadKey();
        }
    }
}
