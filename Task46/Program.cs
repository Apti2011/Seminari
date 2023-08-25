﻿//Задача 46: Задайте двумерный массив размером m×n,
//заполненный случайными целыми числами.
//m = 3, n = 4.
//   0  1 2  3
//0  1  4 8  19
//1  5 -2 33 -2
//2  77 3  8  1

//Заполнение двухмерного массива
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)//rows(колличество строк) columns(колличество столбцов)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)//количество этераций соответствующих колличеству строк
    {
      for (int j =0; j<matrix.GetLength(1); j++)//количество этераций соответствующих количеству столбцов
        {
          matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix; 
 }

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
    Console.Write("[");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
       Console.Write($"{matrix[i, j]} ");        
    }
    Console.WriteLine("]");
    }
}

int[,] array2d = CreateMatrixRndInt(3, 4, -100, 100);
PrintMatrix(array2d);