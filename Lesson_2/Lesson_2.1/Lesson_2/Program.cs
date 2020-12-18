using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"<<<<<<----- Добрый день ----->>>>>>\n <--На улице {DateTime.Now}-->\n");
            Console.WriteLine("Введите минимальную температуру за сегодня!");
                int minTemperature = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите максимальную температуру за сегодня!");
                int maxTemperature = Convert.ToInt32(Console.ReadLine());
                int averangeTemperature = (maxTemperature + minTemperature) / 2;
            Console.WriteLine($"Сегодня средняя температура такая!! {averangeTemperature}");
            Console.ReadKey();
        }
    }
}
