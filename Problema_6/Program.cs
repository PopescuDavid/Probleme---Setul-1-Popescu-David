using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("a= ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("b= ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("c= ");
            c = int.Parse(Console.ReadLine());
            if(a<b+c && b<a+c && c<a+b)
                Console.WriteLine("Este triunghi");
            else
                Console.WriteLine("Nu este triunghi");
        }
    }
}
