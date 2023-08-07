//Задача 37: Найдите произведение пар чисел в одномерном массиве.
//Парой считаем первый и последний элемент, второй и предпоследний
//и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21
//int[] CreateArrayRndInt(int size, int min, int max){    int[] arr = new int[size];    Random rnd = new Random();    for (int i = 0; i < arr.Length; i++)    {        arr[i] = rnd.Next(min, max + 1);    }    return arr;}void PrintArray(int[] arr){    Console.Write("[");    for (int i = 0; i < arr.Length; i++)    {        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");        else Console.Write($"{arr[i]}");    }    Console.Write("]");}
//int[] СompositionTwoNumbers(int[] arr){    int size = arr.Length / 2 + arr.Length % 2;    int[] newArr = new int[size];    for (int i = 0; i < size; i++)    {        newArr[i] = arr[i] * arr[arr.Length - 1 - i];    }    if (arr.Length % 2 == 1) newArr[size - 1] = arr[arr.Length / 2];    return newArr;}int[] array = CreateArrayRndInt(5, 1, 9);int[] resultArray = СompositionTwoNumbers(array);PrintArray(array);Console.Write(" -> ");PrintArray(resultArray);Console.WriteLine();

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }

    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
            Console.Write($"{arr[i]}, ");
        else
            Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

int[] СompositionTwoNumbers(int[] arr)
{
  //Мы хотим определить размер нового массива, потому что он у нас будет разным 
  //взависимости от того будут у нас четные или не четные элементы
  //если массив четный то размер результирующего бужет половина исходного arr.Length / 2, 
  //а если нечетное то делим его на два и плюс остаток от деления  на 2 arr.Length / 2 + arr.Length % 2 и еще + 1
    int size = arr.Length / 2 + arr.Length % 2;
    int[] newArr = new int[size];

    for (int i = 0; i < size; i++)
    {
        newArr[i] = arr[i] * arr[arr.Length - 1 - i];//перемножаем левый и правый элемент массива
    }
//если это не четный массив то мы последний элемент массива перемножается на самого себя, то есть по середине
//он не имеет пары, мы берем его с предыдущего массива и вставляем в конец полученного, перезаписываем это значение
    if (arr.Length % 2 == 1)
        newArr[size - 1] = arr[arr.Length / 2];

    return newArr;
}

int[] array = CreateArrayRndInt(5, 1, 9);//создание массива и заполнение случайными числами
int[] resultArray = СompositionTwoNumbers(array);

PrintArray(array);//выводим на экран исходный массив 
Console.Write(" -> ");
PrintArray(resultArray);//выводим на экран результирующий массив 
Console.WriteLine();


// Метод с округлением
// ===================
// void PrintArrayDouble(double[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         double roundNum = Math.Round(arr[i], 1);
//         if (i < arr.Length - 1) Console.Write($"{roundNum}, ");
//         else Console.Write($"{roundNum}");
//     }
//     Console.Write("]");
// }