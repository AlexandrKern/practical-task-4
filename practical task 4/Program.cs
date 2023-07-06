using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practical_task_4
{
    internal class Program
    {
        //Задание 1. Случайная матрица
        static void Main(string[] args)
        {
            Console.WriteLine("Создание матрицы.");
            Console.WriteLine();
            Console.Write("Введите количество строк:");
            int line = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов:");
            int column = int.Parse(Console.ReadLine());
            int[,] matrix = new int[line, column];
            Random random = new Random();
            int sum = 0;
            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    matrix[i, j] = random.Next(10);
                    Console.Write($"{matrix[i, j],3}");
                    sum += matrix[i, j];
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.WriteLine($"Cумма всех элементов матрицы: {sum}");
            Console.ReadKey();
            Console.WriteLine();
            //Задание 2.Сложение матриц
            Console.WriteLine("Задание 2.Сложение матриц");
            
            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write($"{matrix[i, j],3}");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.WriteLine("  ++++++++++");
            Console.WriteLine();
            int[,] matrix2 = new int[line, column];
            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    matrix2[i, j] = random.Next(10);
                    Console.Write($"{matrix2[i, j],3}");
                   
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.WriteLine("Результат сложения");
            int [,] matrix3 = new int[line, column];
            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    matrix3[i,j] = matrix[i,j] + matrix2[i,j];
                    Console.Write($"{matrix3[i, j],3}");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
