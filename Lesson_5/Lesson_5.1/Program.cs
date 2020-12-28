using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите произвольный набор данных: ");
            string text = Console.ReadLine();
            string myFile = "text.txt";
            File.WriteAllText(myFile, text);

            Console.Write("В вашем файле сейчас записано: ");
            string readFile = File.ReadAllText(myFile);
            Console.Write(readFile);

            Console.ReadLine();
        }
        
    }
}
