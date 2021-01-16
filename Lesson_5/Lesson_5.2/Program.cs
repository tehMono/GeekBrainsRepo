using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = "startup.txt";
            string time = $"Время вызова программы: {DateTime.Now.ToString()}\n";
            File.AppendAllText(file, time);

                Console.Write("В вашем файле сейчас записано:\n");

            string readFile = File.ReadAllText(file);

                Console.Write(readFile);
                Console.ReadLine();

        }
    }
}
