using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("3. Написать программу, выводящую введенную пользователем строку в обратном порядке");

            Console.Write("\nНапишите ваше слово: ");

            string yourWord = Console.ReadLine();
        
            Console.WriteLine($"\nВаше слово наоборот: "+new string(yourWord.Reverse().ToArray()));
            Console.ReadLine();

        }
    }
}
