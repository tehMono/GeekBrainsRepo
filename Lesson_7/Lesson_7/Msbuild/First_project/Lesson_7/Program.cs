// Decompiled with JetBrains decompiler
// Type: Lesson_7.Program
// Assembly: Lesson_7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2033C5A8-1936-4075-92CA-B4CB16FD9AE2
// Assembly location: G:\GeekBrains\lessons\Lesson_7\Lesson_7\bin\Release\Lesson_7.exe

using System;

namespace Lesson_7
{
  internal class Program
  {
    private static int result;

    private static void Main(string[] args)
    {
      Console.Title = "Калькулятор";
      Console.WriteLine("Наш калькулятор умеет делать : сложение(+), вычитание(-), умножение(*) и деление(/).");
      Console.ReadLine();
      Console.WriteLine("Введите первое число:");
      int a = int.Parse(Console.ReadLine());
      Console.WriteLine("Введите знак операции:");
      string op = Console.ReadLine();
      Console.WriteLine("Введите второе число:");
      int b = int.Parse(Console.ReadLine());
      Console.WriteLine("Ваш результат: {0} {1} {2} = {3}", new object[4]
      {
        (object) a,
        (object) op,
        (object) b,
        (object) Program.Math(a, b, op)
      });
      Console.ReadLine();
    }

    private static int Math(int a, int b, string op)
    {
      Program.result = op == "+" ? a + b : (op == "-" ? a - b : (op == "*" ? a * b : (op == "/" ? a / b : 0)));
      return Program.result;
    }
  }
}
