using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("n= ");
            n = int.Parse(Console.ReadLine());
            while(n!=0)
            {
                Console.Write(n % 10 + " ") ;
                n = n / 10;
            }
        }
    }
}
