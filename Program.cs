using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewtonMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, epsilon, Newton, MathPow;
            int n;
            Console.WriteLine("Hello!");
            Console.WriteLine("Please, enter pow: ");
            string str_n = Console.ReadLine();
            n = Convert.ToInt32(str_n);

            Console.WriteLine("Please, enter A: ");
            string str_a = Console.ReadLine();
            a = Convert.ToDouble(str_a);

            Console.WriteLine("Please, enter Epsilon: ");
            string str_epsilon = Console.ReadLine();
            epsilon = Convert.ToDouble(str_epsilon);

            double x = 1;
            while (Math.Abs(Math.Pow(x, n) - a) >= epsilon)
            {
                x = (Math.Pow(n, -1) * ((n - 1) * x + (a / Math.Pow(x, n - 1))));
            }
            Newton = x;
            Console.WriteLine(Newton + " for Newton method");

            MathPow = Math.Pow(a, Math.Pow(n, -1));

            Console.WriteLine(MathPow + " for Math.Pow method");

            if (Newton > MathPow)
            {
                Console.WriteLine("Newton method is bigger");
            }
            else
            {
                Console.WriteLine("Program method is bigger");
            }
            Console.ReadKey();

        }
    }
}
