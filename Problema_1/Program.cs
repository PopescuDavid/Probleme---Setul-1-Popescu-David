using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            double x;
            Console.WriteLine($"Dati valoarea lui a = ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine($"Dati valoarea lui b = ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Ecuatia de gradul I este: {a}x+{b}=0");
            x = -b / a;
            Console.WriteLine($"Daca il scoatem pe x din ecuatia rezulta => x=-{b}/{a} care este egal cu {x}");
        }
    }
}
