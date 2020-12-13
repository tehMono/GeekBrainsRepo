using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
                Console.WriteLine("Введите число, которое мы будем проверять:");
            number = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Проверка");   
            if (number % 2 == 0)                                
                Console.WriteLine("Ваше число четное!");
            else
                Console.WriteLine("Ваше число нечетное!");            
                Console.ReadKey();
        }        
    }
}
