//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)//rows(колличество строк) columns(колличество столбцов)
{
  int[,] matrix = new int[rows, columns];
  Random rnd = new Random();

  for (int i = 0; i < matrix.GetLength(0); i++)//количество итераций соответствующих колличеству строк
  {
    for (int j = 0; j < matrix.GetLength(1); j++)//количество итераций соответствующих количеству столбцов
    {
      matrix[i, j] = rnd.Next(min, max + 1);
    }
  }
  return matrix;
}
//Метод печати двухмерного массива и вывод в консоль
void PrintMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write($"{matrix[i, j],1} ");
    }
    Console.WriteLine();
  }
}

void SortDescendingElements(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int a = 0;
            while (a < matrix.GetLength(1) - 1)
            {
                if (matrix[i, a] < matrix[i, a + 1])
                {
                    int temp = matrix[i, a + 1];
                    matrix[i, a + 1] = matrix[i, a];
                    matrix[i, a] = temp;
                }
                a++;
            }
        }
    }
}

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 5);
PrintMatrix(array2d);
Console.WriteLine();
SortDescendingElements(array2d);
PrintMatrix(array2d);
