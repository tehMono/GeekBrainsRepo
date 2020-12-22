using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4._1
{
    class Program
    {

        /* Написать метод GetFullName(string firstName, string lastName, string patronymic),
         * принимающий на вход ФИО в разных аргументах и возвращающий объединённую строку с ФИО.
         * Используя метод, написать программу, выводящую в консоль 3–4 разных ФИО.
         */
        
        static void Main(string[] args)
        {
            int count = 3;                      //кол-во запросов!
            for (int i = 0; i < count; i++)
            {
                
                Console.WriteLine(GetFullName());
                
            }
            Console.ReadLine();
        }
        
        static string GetFullName()
        {
            Console.Write("Ваша фамилия: ");
            string firstName = Console.ReadLine();
            Console.Write("Ваше имя: ");
            string lastName = Console.ReadLine();
            Console.Write("Ваше отчество: ");
            string patronymic = Console.ReadLine();

            return ($"ФИО: {firstName} {lastName} {patronymic}"); 
        }
        
    }
}
