//Задача 53: Задайте двумерный массив. Напишите программу,
//которая поменяет местами первую и последнюю строку массива.
//Метод создания двух мерного массива и заполнения двухмерного массива случайными целыми числами

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

void ChangeRows(int[,] matrix, int firstRow, int secondRow)
{
  //int firstRow = 0;
  //int secondRow = matrix.GetLength(0) - 1;
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    //(matrix[secondRow, j], matrix[firstRow. j])=(matrix[firstRow, j], matrix[secondRow. j]);
    int temp = matrix[firstRow, j];
    matrix[firstRow, j] = matrix[secondRow, j];
    matrix[secondRow, j] = temp;
  }
}


int[,] array2d = CreateMatrixRndInt(5, 4, -100, 100);
PrintMatrix(array2d);
Console.WriteLine();
int lastRow = array2d.GetLength(0)-1;
ChangeRows(array2d, 0, lastRow); //0 первая строка, lastRow последняя.
PrintMatrix(array2d);
