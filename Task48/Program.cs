﻿//Задача 48: Задайте двумерный массив размера m на n,
//каждый элемент в массиве находится по формуле: Amn = m+n.
//Выведите полученный массив на экран.
//m = 3, n = 4.
//0 1 2 3
//1 2 3 4
//2 3 4 5


int[,] CreateMatrixSumInd(int rows, int columns)//rows(колличество строк) columns(колличество столбцов)
{
int[,] matrix = new int [rows, columns];
   for (int i = 0; i < matrix.GetLength(0); i++)//количество этераций соответствующих колличеству строк
    {
      for (int j =0; j<matrix.GetLength(1); j++)//количество этераций соответствующих количеству столбцов
        {
          matrix[i, j] = i+j;
        }
    }
    return matrix; 
 }

//Метод печати двухмерного массива и вывод в консоль
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
    //Console.Write("|");
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
       Console.Write($"{matrix[i, j], 6} ");//, 6 длина строки куда помещается результат вывода       
    }
    //Console.WriteLine("|");
    Console.WriteLine();
    }
}

int[,] array2d = CreateMatrixSumInd(3, 4);
PrintMatrix(array2d);