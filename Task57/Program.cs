//Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит
//информацию о том, сколько раз встречается элемент входных данных.

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

int[] MatrixToArray(int[,] matrix)
{
  int[] arr = new int[matrix.Length];
  int k = 0;
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      arr[k] = matrix[i, j];
      k++;
    }
  }
  return arr;
}
void FrequencyNumDictionary(int[] arr)
{
  int currentNum = arr[0];
  int count = 1;
  for (int i = 1; i < arr.Length; i++)
  {
    if (arr[i] == currentNum) count++;
    else
    {
      Console.WriteLine($"Количество {currentNum} -> {count}.");
      currentNum = arr[i];
      count = 1;
    }
  }
  Console.WriteLine($"Количество {currentNum} -> {count}.");
}
int[,] array2d = CreateMatrixRndInt(3, 3, 1, 9);
PrintMatrix(array2d);
Console.WriteLine();
int[] array = MatrixToArray(array2d);
Array.Sort(array);
int[] arrayTemp = { 1, 1, 1, 2, 2, 2, 3, 3, 3, 9, 9, 9, 9 };
// Console.WriteLine(string.Join(" ", array));
FrequencyNumDictionary(arrayTemp);