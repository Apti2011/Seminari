//Задача 55: Задайте двумерный массив. Напишите программу,
//которая заменяет строки на столбцы. В случае, если это
//невозможно, программа должна вывести сообщение для
//пользователя.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)//rows(колличество строк) columns(колличество столбцов)
{
  int[,] matrix = new int[rows, columns];
  Random rnd = new Random();

  for (int i = 0; i < matrix.GetLength(0); i++)//количество этераций соответствующих колличеству строк
  {
    for (int j = 0; j < matrix.GetLength(1); j++)//количество этераций соответствующих количеству столбцов
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
      Console.Write($"{matrix[i, j],6} ");//, 6 длина строки куда помещается результат вывода       
    }
    Console.WriteLine();
  }
}
void SwapRowsColumns(int[,] matrix)
{
    // for (int i = 1; i < matrix.GetLength(0); i++) // 1-0   2-0   2-1   3-0   3-1   3-2
 for (int i = 0; i < matrix.GetLength(0)-1; i++) // 0-1   0-2   0-3   1-2   1-3   2-3
 {
        // for (int j = 0; j < i; j++)
         for (int j = i + 1; j < matrix.GetLength(1); j++)
        {
int temp = matrix[i, j];
matrix[i, j] = matrix[j, i];
matrix[j, i] = temp;
}
}
}
bool ValidateSquareMatrix(int[,] matrix)
{
 return matrix.GetLength(0) == matrix.GetLength(1);
}
int[,] array2d = CreateMatrixRndInt(3, 3, 1, 9);
PrintMatrix(array2d);
Console.WriteLine();
if (ValidateSquareMatrix(array2d))
{
 SwapRowsColumns(array2d);
 PrintMatrix(array2d);
}
else Console.WriteLine("Невозможно заменить строки на столбцы.");
