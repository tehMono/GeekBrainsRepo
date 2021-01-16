using System;
using System.IO;


namespace Lesson_5._3
{
    class Program
    {
        /// <summary>
        /// Ввести с клавиатуры произвольный набор чисел (0...255) и записать их в бинарный файл.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Write("Сколько чисел вы хотите добавить? : ");
            int count = int.Parse(Console.ReadLine());
        
            byte[] array = new byte[count];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Введите число номер {i} : ");
                array[i]  = byte.Parse(Console.ReadLine());
            }
            string data = "test.data";
            File.WriteAllBytes(data, array);
            Console.WriteLine($"Ваши числа были записаны в бинарный файл {data}");
            Console.ReadLine();
        }
      
    }
}
