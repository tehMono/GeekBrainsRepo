using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7
{
    class Program
    {
        static double result = 0;

        static void Main(string[] args)
        {
            Console.Title = "Калькулятор";
            Console.WriteLine("Наш калькулятор умеет делать : сложение(+), вычитание(-), умножение(*) и деление(/).");
            

            string c ;
            double a, b;
            

            Console.WriteLine("Введите первое число:");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите знак операции:");
            c = Console.ReadLine();

            Console.WriteLine("Введите второе число:");
            b = double.Parse(Console.ReadLine());


            Console.WriteLine("Ваш результат: {0} {1} {2} = {3}", a, c, b, Math(a, b, c));
            Console.ReadLine();
        }

        static double Math(double a,double b,string op)
        {
            switch (op)
            {
                case "+":
                    result = a + b;
                    break;

                case "-":
                    result = a - b;
                    break;

                case "*":
                    result = a * b;
                    break;

                case "/":
                    result = a / b;
                    break;

                default:
                    result = 0;
                    break;
            }
            return result;
        }
    }
}
