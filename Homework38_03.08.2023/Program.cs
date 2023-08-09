//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        //NextDouble() генерирует случайные вещественные числа. 
        //* (max - min) + min будем получать числа в нужном диапозоне
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }

    return arr;
}

void PrintArrayDouble(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        //double roundNum = Math.Round(arr[i], 1);//округление после запятой на один знак
        if (i < arr.Length - 1)
            Console.Write($"{arr[i]:F2}, ");
        else
            Console.Write($"{arr[i]:F2}");
    }
    Console.Write("]");
}
double MaxElement(double[] arr)
{
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    return max;
}
double MinElement(double[] arr)
{
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min) min = arr[i];
    }
    return min;
}

double[] array = CreateArrayRndDouble(4, 1, 99);//создание массива и заполнение случайными числами
PrintArrayDouble(array);//выводим на экран исходный массив 
double maxelement = MaxElement(array);
double minelement = MinElement(array);
Console.WriteLine($" => {maxelement:F2} - {minelement:F2} = {maxelement - minelement:F2}");//:F2 округление до двух знаков после запятой