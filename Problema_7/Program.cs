using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_7
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
            aux = a;
            a = b;
            b = aux;
            Console.WriteLine($"Valorile dupa inversare sunt {a} {b}");
        }
    }
}
