using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t«2. Телефонный справочник»");
            Console.WriteLine("\tЗаполните форму:");
            int a = 0;
            string[,] massive = new string[5, 2];
            while (a <5)
            {
                Console.Write("Введите имя:");
                string name = Console.ReadLine();
                Console.Write("Введите телефон или email:");
                var PhoneOrMail = Console.ReadLine();
                massive[a, 0] = name;
                massive[a, 1] = PhoneOrMail;
                a++;
                
            }
            Console.WriteLine();
            for (int y = 0; y < massive.GetLength(0); y++)
            {
                for (int x = 0; x < massive.GetLength(1); x++)
                {
                    Console.Write(massive[y, x] + "\t");
                }
                Console.WriteLine();
            }

           
            
            Console.ReadKey();
        }
    }
}
