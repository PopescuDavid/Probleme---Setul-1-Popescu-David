using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c,aux;
            Console.WriteLine("a= ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("b= ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("c= ");
            c = int.Parse(Console.ReadLine());
            if (a > b)
            {
                aux = a;
                a = b;
                b = aux;
            }
            if(a>c)
            {
                aux = a;
                a = c;
                c = aux;
            }
            if(b>c)
            {
                aux = b;
                b = c;
                c = aux;
            }
            Console.WriteLine($"Numerele ordonate crescator sunt {a} {b} {c}");

        }
    }
}
