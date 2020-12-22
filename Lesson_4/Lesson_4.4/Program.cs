using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Укажите число из последовательности Фибоначи: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int myFib = Fibonachi(num);
            Console.WriteLine(myFib);
            Console.ReadLine();
        }

        static int Fib(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return Fib(n - 1) + Fib(n - 2);
            }
        }
    }
}
