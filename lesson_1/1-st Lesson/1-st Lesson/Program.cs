using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_st_Lesson
{
    class Program
    {
        static void Main(string[] args)
        {

                Console.WriteLine("Привет, как тебя зовут?");       //Вывод на консоль 
                string name = Console.ReadLine();                   //Считываем и записываем в переменную (name)
                Console.WriteLine($"Привет! {name}, сегодня [{DateTime.Now}] ");
                Console.ReadLine();
            
        }
    }

}
   