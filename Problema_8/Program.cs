using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b,aux;
            Console.WriteLine("a= ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("b= ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Valorile inainte de inversare sunt {a} {b}");
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"Valorile dupa inversare sunt {a} {b}");
        }
    }
}
