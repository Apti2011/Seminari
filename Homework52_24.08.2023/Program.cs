//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void Avarage(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double result = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            result += matrix[i, j];
        }
        result /= 3;
        Console.Write($"{result:F1} ");
    }
}

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 5);
PrintMatrix(array2d);
Console.Write($"Среднее арифметическое каждого столбца: ");
Avarage(array2d);