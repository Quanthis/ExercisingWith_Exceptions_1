using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp53
{
    class Program
    {
        static void Main(string[] args)
        {//D4.1
            int a, iloraz;
            try
            {
                Console.Write("Tell me natural number a=");
                a = Convert.ToInt32(Console.ReadLine());
                iloraz = 1000 / a;
                Console.WriteLine("Modulo for: 1000/{0}={1}", a, iloraz);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("You tried to divide by 0");
            }
            Console.ReadKey();
        }
    }
}
