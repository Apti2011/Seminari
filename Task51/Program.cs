// Задача 51: Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

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

int SumMainElemMatrix(int[,] matrix)
{
  int j = 0;
  int sum = 0;
  int minSize=0;
  //int minSize = matrix.GetLength(0) < matrix.GetLength(1) ? matrix.GetLength(0) : matrix.GetLength(1);
  if (matrix.GetLength(0) < matrix.GetLength(1)) {minSize=matrix.GetLength(0);}
  for (int i = 0; i < minSize; i++)//i=j
  {
    j=i;
    sum += matrix[i, j];
  }
  return sum;
}

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 5);
PrintMatrix(array2d);
int result = SumMainElemMatrix(array2d);
Console.WriteLine($"Cумма элементов, находящихся на главной диагонали {result}");