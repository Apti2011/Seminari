// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого элемента в массиве нет

Console.WriteLine("Введите позицию элемента относительно стпрки на двухмерном массиве");
int itemPosition_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию элемента относительно столбца на двухмерном массиве");
int itemPosition_2 = Convert.ToInt32(Console.ReadLine());

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
            Console.Write($"{matrix[i, j],6} ");//, 6 длина строки куда помещается результат вывода       
        }
        Console.WriteLine();
    }
}
void SearchItemPosition(int[,] matrix, int itemPos_1, int itemPos_2)
{
  if (itemPos_1 < 0 || itemPos_2 < 0) 
  {Console.WriteLine("Позиция элемента ни может быть отрицательным");}
  else if (itemPos_1 > matrix.GetLength(0)-1 || itemPos_2 > matrix.GetLength(1)-1) 
   { Console.WriteLine($"{itemPos_1},{itemPos_2}->такого элемента в массиве нет"); }
   else Console.WriteLine($"{itemPos_1},{itemPos_2}->такой элемент {matrix[itemPos_1,itemPos_2]} в массиве есть");              
}
int[,] array2d = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(array2d);
SearchItemPosition(array2d, itemPosition_1, itemPosition_2);
