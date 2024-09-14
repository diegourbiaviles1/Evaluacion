using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Arreglos_en_C__2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] tabla1 = new int[3, 3];
            int f, c;
            int sumatotal = 0;

            Console.WriteLine("Programa usando arreglos bidimensionales");
            Console.WriteLine("Ingrese los valores del arreglo: ");
            //Llenna el arreglo
            for (f = 0; f < 3; f++)
            {
                for (c = 0; c < 3; c++)
                {
                    tabla1[f, c] = int.Parse(Console.ReadLine());
                    sumatotal += tabla1[f, c];
                }
            }
            //Se imprime el arreglo
            Console.WriteLine("Imprimiendo el arreglo....");
            for (f = 0; f < 3; f++)
            {
                for (c = 0; c < 3; c++)
                {
                    Console.Write(tabla1[f, c] + " ");
                }
                Console.WriteLine();
            }

            // Mostramos la suma del arreglo
            Console.WriteLine("La suma total de los numeros es: " + sumatotal);

            Console.ReadKey();
        }
    }
}
