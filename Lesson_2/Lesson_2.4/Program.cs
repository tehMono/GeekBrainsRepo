using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2._4
{
    class Program
    {
        public static void Main(string[] args)
        {
            int numberOfmonth;
            string nameOfmonth = "";
            int minTemperature;
            int maxTemperature;
            /*
             *                  Задание номер 1.
             *                  
             */
                Console.WriteLine("\nЗадание номер 1.\nВведите минимальную температуру за сегодня!");
            minTemperature = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите максимальную температуру за сегодня!");
            maxTemperature = Convert.ToInt32(Console.ReadLine());
            int averangeTemperature = (maxTemperature + minTemperature) / 2;
                Console.WriteLine($"Сегодня средняя температура такая!! {averangeTemperature}");
                Console.WriteLine("Для продолжения нажмите любую кнопку...");
                Console.ReadKey();
            /*
             *                  Задание номер 2.
             *
             */
                Console.WriteLine("Задание номер 2.\nНапишите номер месяца!");
            numberOfmonth = Convert.ToInt32(Console.ReadLine());
            switch (numberOfmonth)                                            
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
            if (trueMonth == nameOfmonth)                                                   //если без проверки! Console.WriteLine($"Вы выбрали месяц: {nameOfmonth}");
                Console.WriteLine($"Действительно месяц который вы ввели верный!\nИ сейчас у нас {nameOfmonth}");
            else
            {
                Console.WriteLine($"Что то не сходится, сейчас месяц {trueMonth}");
                return;
            }
                Console.WriteLine("Для продолжения нажмите любую клавишу...");
                Console.ReadKey();
            /*
             *                  Задание номер 3.
             * 
             */
                Console.WriteLine("Задание номер 3.\nПроверка числа, введенного во втором задании на четность");   
            if (numberOfmonth % 2 == 0)                                
                Console.WriteLine("Число которое вы ввели: четное!");
            else
                {
                Console.WriteLine("Число которое вы ввели: нечетное!");            
                Console.ReadKey();
                }
            /*
             *                  Задание номер 4.
             * 
             */
                Console.WriteLine("Задание номер 4.\n");
            if ((numberOfmonth < 3 || numberOfmonth == 12) || averangeTemperature >0 ) Console.WriteLine("Дождливая Зима");
            else if (numberOfmonth < 6)     Console.WriteLine("А у нас Весна");
            else if (numberOfmonth < 9)     Console.WriteLine("Ура... Лето");
            else if (numberOfmonth < 12)    Console.WriteLine("Опять Осень");
            
        }
    }
}
