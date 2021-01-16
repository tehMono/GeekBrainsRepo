using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;

namespace Lesson_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Greetings.SayHello();   // немного dll

            Console.WriteLine(Properties.Settings.Default.Hello);

            Console.Write("если хотите очистить таблицы напишите clean: ");
            string clean = Console.ReadLine();
            if (clean == "clean")
            {
                Properties.Settings.Default.Reset();
            }
            else
            
            if (string.IsNullOrEmpty(Properties.Settings.Default.Name) && string.IsNullOrEmpty(Properties.Settings.Default.Age) && string.IsNullOrEmpty(Properties.Settings.Default.job))
            {
                Console.Write("Введите ваше имя: ");
                Properties.Settings.Default.Name = Console.ReadLine();
                Console.Write("Cколько вам лет: ");
                Properties.Settings.Default.Age = (Console.ReadLine());
                Console.Write("Ваш род деятельности: ");
                Properties.Settings.Default.job = Console.ReadLine();
                Properties.Settings.Default.Save();
            }
            else
            {
                string name = Properties.Settings.Default.Name;
                string age = Properties.Settings.Default.Age;
                string job = Properties.Settings.Default.job;
                Console.WriteLine("Привет {0} {1} {2}", name, age, job);
            }

            Console.ReadKey();
        }

    }
}
