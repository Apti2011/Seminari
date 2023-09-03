//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

int[,] CreateMatrixRndInt1(int rows, int columns, int min, int max)//rows(колличество строк) columns(колличество столбцов)
{
    int[,] matrix1 = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix1.GetLength(0); i++)//количество итераций соответствующих колличеству строк
    {
        for (int j = 0; j < matrix1.GetLength(1); j++)//количество итераций соответствующих количеству столбцов
        {
            matrix1[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix1;
}
int[,] CreateMatrixRndInt2(int rows, int columns, int min, int max)//rows(колличество строк) columns(колличество столбцов)
{
    int[,] matrix2 = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix2.GetLength(0); i++)//количество итераций соответствующих колличеству строк
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)//количество итераций соответствующих количеству столбцов
        {
            matrix2[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix2;
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

//Нахождение произведения двух матриц
void ProductTwoMatrices (int[,] matrix1, int[,] matrix2)
{
    int sum1 = (matrix1[0, 0] * matrix2[0, 0]) + (matrix1[0, 1] * matrix2[1, 0]);
    int sum2 = (matrix1[0, 0] * matrix2[0, 1]) + (matrix1[0, 1] * matrix2[1, 1]);
    int sum3 = matrix1[1, 0] * matrix2[0, 0] + matrix1[1, 1] * matrix2[1, 0];
    int sum4 = matrix1[1, 0] * matrix2[0, 1] + matrix1[1, 1] * matrix2[1, 1];
    Console.WriteLine($"{sum1} {sum2}");
    Console.WriteLine($"{sum3} {sum4}");
}
int[,] array2d1 = CreateMatrixRndInt1(2, 2, 1, 9);
PrintMatrix(array2d1);
int[,] array2d2 = CreateMatrixRndInt2(2, 2, 1, 9);
PrintMatrix(array2d2);
ProductTwoMatrices(array2d1, array2d2);