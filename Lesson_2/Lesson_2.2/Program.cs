using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfmonth;
            string nameOfmonth = "";
            Console.WriteLine("Напишите номер месяца!");
            numberOfmonth = Convert.ToInt32(Console.ReadLine());
            switch (numberOfmonth)                                            //switch-case 
            {
                case 1:
                      nameOfmonth = "Январь";
                      break;
                case 2:
                      nameOfmonth = "Февраль";
                      break;
                case 3:
                      nameOfmonth = "Март";
                      break;
                case 4:
                      nameOfmonth = "Апрель";
                      break;
                case 5:
                      nameOfmonth = "Май";
                      break;
                case 6:
                      nameOfmonth = "Июнь";
                      break;
                case 7:
                      nameOfmonth = "Июль";
                      break;
                case 8:
                      nameOfmonth = "Август";
                      break;
                case 9:
                      nameOfmonth = "Сентябрь";
                      break;
                case 10:
                      nameOfmonth = "Октябрь";
                      break;
                case 11:
                      nameOfmonth = "Ноябрь";
                      break;
                case 12:
                      nameOfmonth = "Декабрь";
                      break;
                default:
                      Console.WriteLine("Вы ввели некорректное число!В году 12 месяцев!");
                      Console.ReadKey();
                      return;  // закончить Main
         }
            string trueMonth = DateTime.Now.ToString("MMMM");                           // проверка даты
            if (trueMonth == nameOfmonth)                                              //если без проверки! Console.WriteLine($"Вы выбрали месяц: {nameOfmonth}");
                Console.WriteLine($"Действительно месяц который вы ввели верный!\nИ сейчас у нас {nameOfmonth}");    
            else
                Console.WriteLine($"Что то не сходится, сейчас месяц {trueMonth}");            
            Console.ReadKey();
        }
       
    }
}


 