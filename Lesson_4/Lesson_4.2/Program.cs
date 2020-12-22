using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4._2
{
    class Program
    {
        /*
         * Написать программу, принимающую на вход строку — набор чисел, разделенных пробелом,
         * и возвращающую число — сумму всех чисел в строке.
         * Ввести данные с клавиатуры и вывести результат на экран.
        */
        static void Main(string[] args)
        {
            Console.WriteLine("введите числа через пробел");
            string numbers = Console.ReadLine();
            numbers = numbers.Replace(" ","");
            int count = Convert.ToInt32(numbers);
            int summ = sum(count);
            Console.WriteLine(summ);
            Console.ReadLine();

        }
        static int sum(int count)
        {
            int sum = 0;
            while (count>0)
            {
                sum += count % 10;
                count = count / 10;
            }
            return sum;
        }
            
    }
}
