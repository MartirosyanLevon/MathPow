using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathPow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pease write your digit");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Now write what degree do you want to count");
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Math.Pow(a, b);
            Console.WriteLine("Your numbre is {0}", c);
            Console.ReadLine();
        }
    }
    
}
