//Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму
//отрицательных и положительных элементов массива. Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
//положительных чисел равна 29, сумма отрицательных равна -20.

int[] CreateArrayRndInt(int size, int min, int max)//метод, для создания и заполнения цикла случайными числами
{
    int[] arr = new int[size];//создаем массив, по умалчанию массив заполнен нулями
    Random rnd = new Random();//создаем объект Random и внутри цикла его использовать

    for (int i = 0; i < arr.Length; i++)//цикл для прохода по всем элементам массива
    {
        arr[i] = rnd.Next(min, max + 1);//заплняем массив случайными числами
    }

    return arr; //возврат массива
}
void PrintArray(int[] arr)//Метод(функция) для вывода массива в консоль
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

//Возврат суммы отрицательных и положительных элементов массива одним методом
// int[] GetSumPositiveNegativeElem(int[] arr)
// {
// int sumNegative =0;
// int sumNegative =0;
// for (int i = 0; i < arr.Length; i++)
// {
//     if(arr[i] < 0) sumNegative += arr[i];//sumNegative = sumNegative + arr[i];
//     else sumPositive += arr[i];
// }
//     return new int[]{sumNegative, sumPositive};
// }
//int[] sumPositiveNegativeElem = GetSumPositiveNegativeElem(array); // вызов метода
//Console.WriteLine($"Сумма отрицательных элементов = {sumPositiveNegativeElem[0]}");
//Console.WriteLine($"Сумма положительных элементов = {sumPositiveNegativeElem[1]}");

int GetSumPositiveElem(int[] arr)//Найти сумму положительных элементов массива
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) sum += arr[i];
    }
    return  sum;
}

int GetSumNegativeElem(int[] arr)//Найти сумму отрицательных элементов массива
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < 0) sum += arr[i];
    }
    return  sum;
}
int[] array = CreateArrayRndInt(12, -9, 9);
PrintArray(array);



int sumPositiveElem = GetSumPositiveElem(array);
int sumNegativeElem = GetSumNegativeElem(array);
Console.WriteLine("");
Console.WriteLine($"Сумма отрицательных элементов = {sumNegativeElem}");
Console.WriteLine($"Сумма положительных элементов = {sumPositiveElem}");