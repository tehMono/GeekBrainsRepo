﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Написать программу, выводящую элементы двумерного массива по диагонали.");
            
            int[,] matrix = new int[10, 10];
            int a = 0;

            while (a < 10)
            {
                matrix[a, a] = 1;
                a++;
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
