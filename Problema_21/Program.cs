using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Random sol = new Random();
            int solutie = sol.Next(1024);
            Console.WriteLine(solutie);
            int n;
            do
            {
                Console.Write("Dati un numar intre 1 si 1024: ");
                n = int.Parse(Console.ReadLine());
                if (n < solutie)
                    Console.WriteLine("Numarul este prea mic!");
                else if (n == solutie)
                {
                    Console.WriteLine();
                    Console.WriteLine("Bravo! Ai ghicit!");
                }
                else
                    Console.WriteLine("Numarul  prea mare!");
            }
            while (n != solutie);
            Console.ReadKey();
        }
    }
}
