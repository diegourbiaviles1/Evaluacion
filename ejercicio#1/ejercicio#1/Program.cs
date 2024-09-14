using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] sumCounts = new int[13]; 
            int totalRolls = 36000;

            for (int i = 0; i < totalRolls; i++)
            {
                int die1 = rand.Next(1, 7); 
                int die2 = rand.Next(1, 7); 
                int sum = die1 + die2;      
                sumCounts[sum]++;           
            }

            
            Console.WriteLine("Suma\tFrecuencia\tPorcentaje");
            for (int sum = 2; sum <= 12; sum++)
            {
                double percentage = (double)sumCounts[sum] / totalRolls * 100;
                Console.WriteLine($"{sum}\t{sumCounts[sum]}\t\t{percentage:F2}%");
            }

            
            double sevenPercentage = (double)sumCounts[7] / totalRolls * 100;
            Console.WriteLine($"\nEl porcentaje de tiradas con suma 7 es aproximadamente: {sevenPercentage:F2}%");
        }
    }
}
