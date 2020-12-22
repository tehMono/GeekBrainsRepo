using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4._3
{
    class Program
    {
        /*Написать метод по определению времени года. На вход подаётся число – порядковый номер месяца.
         *На выходе — значение из перечисления (enum) — Winter, Spring, Summer, Autumn.
         *Написать метод,принимающий на вход значение из этого перечисления и возвращающий название времени года (зима, весна, лето, осень).
         *Используя эти методы, ввести с клавиатуры номер месяца и вывести название времени года.
         *Если введено некорректное число, вывести в консоль текст «Ошибка: введите число от 1 до 12».
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Введите месяц! от 1 до 12");
            int numberOfmonth = int.Parse(Console.ReadLine());
            takeMonth(numberOfmonth);
            Console.ReadLine();
        }
        static void takeMonth(int number)
        {
            switch (number)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Зима");
                    return;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Весна");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Лето");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Осень");
                    break;
                default:
                    Console.WriteLine("Invalid Month number");
                    break;
            }
        }


    }
}
