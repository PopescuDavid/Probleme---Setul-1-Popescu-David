using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int y;
            Console.WriteLine("y= ");
            y = int.Parse(Console.ReadLine());
            if(y%4==0 || y%400==0)
                Console.WriteLine($"Anul {y} este an bisect");
            else
                Console.WriteLine($"Anul {y} nu este an bisect");
        }
    }
}
