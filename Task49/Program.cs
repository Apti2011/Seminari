// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.
// Например, изначально массив            Новый массив будет выглядеть
// выглядел вот так:                      вот так:
// 1 4 7 2                                1 4 49 2
// 5 9 2 3                                5 9 2 3
// 8 4 2 4                                64 4 4 4

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

//Находим элементы, у которых оба индекса чётные и заменяем эти элементы на их квадраты.
void ReplaceEvenRowsColumnsSquare(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i += 2)//количество этераций соответствующих колличеству строк
  {
    for (int j = 0; j < matrix.GetLength(1); j += 2)//количество этераций соответствующих количеству столбцов
    //{
      //if (i % 2 == 0 && j % 2 == 0)
      {
        matrix[i, j] *= matrix[i, j];
      }
    //}
  }
}

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array2d);
Console.WriteLine();
ReplaceEvenRowsColumnsSquare(array2d);
PrintMatrix(array2d);

