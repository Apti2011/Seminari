//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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
      Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
  }
}

void MinimumLineAmount(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    int lineAmount1 = 0;
    int lineAmount2 = 0;
    int lineAmount3 = 0;
    int lineAmount4 = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      lineAmount1 += matrix[matrix.GetLength(0) - 4, j];
      lineAmount2 += matrix[matrix.GetLength(0) - 3, j];
      lineAmount3 += matrix[matrix.GetLength(0) - 2, j];
      lineAmount4 += matrix[matrix.GetLength(0) - 1, j];
    }
    if (lineAmount1 < lineAmount2 && lineAmount1 < lineAmount3
    && lineAmount1 < lineAmount4) { Console.WriteLine("1 строка"); }
    else if (lineAmount2 < lineAmount1 && lineAmount2 < lineAmount3
    && lineAmount2 < lineAmount4) { Console.WriteLine("2 строка"); }
    else if (lineAmount3 < lineAmount1 && lineAmount3 < lineAmount2
    && lineAmount3 < lineAmount4) { Console.WriteLine("3 строка"); }
    else if (lineAmount4 < lineAmount1 && lineAmount4 < lineAmount2
    && lineAmount4 < lineAmount3) { Console.WriteLine("4 строка"); }
    else Console.WriteLine("Несколько сумм элементов в строках массива равны и имеют наименьшую сумму элементов");
    Console.WriteLine($"{lineAmount1} {lineAmount2} {lineAmount3} {lineAmount4}");
    break;
  }
}

int[,] array2d = CreateMatrixRndInt(4, 4, 1, 9);
PrintMatrix(array2d);
MinimumLineAmount(array2d);