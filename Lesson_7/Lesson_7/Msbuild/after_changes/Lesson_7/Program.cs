// Decompiled with JetBrains decompiler
// Type: Lesson_7.Program
// Assembly: Lesson_7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E49A7DBE-B95B-4470-B393-344FFA6C1A97
// Assembly location: G:\GeekBrains\lessons\Lesson_7\Lesson_7\bin\Release\Lesson_7.exe

using System;

namespace Lesson_7
{
  internal class Program
  {
    private static double result;

    private static void Main(string[] args)
    {
      Console.Title = "Калькулятор";
      Console.WriteLine("Наш калькулятор умеет делать : сложение(+), вычитание(-), умножение(*) и деление(/).");
      Console.WriteLine("Введите первое число:");
      double a = double.Parse(Console.ReadLine());
      Console.WriteLine("Введите знак операции:");
      string op = Console.ReadLine();
      Console.WriteLine("Введите второе число:");
      double b = double.Parse(Console.ReadLine());
      Console.WriteLine("Ваш результат: {0} {1} {2} = {3}", new object[4]
      {
        (object) a,
        (object) op,
        (object) b,
        (object) Program.Math(a, b, op)
      });
      Console.ReadLine();
    }

    private static double Math(double a, double b, string op)
    {
      Program.result = op == "+" ? a + b : (op == "-" ? a - b : (op == "*" ? a * b : (op == "/" ? a / b : 0.0)));
      return Program.result;
    }
  }
}
