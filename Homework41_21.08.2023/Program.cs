//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

Console.Write("Введите количество элементов массива: ");
int elements = Convert.ToInt32(Console.ReadLine());
int[] myArray = new int[elements];

//Заполнение массива с клавиатуры
int [] CreateArray(int[] myArr)
{
    for (int i = 0; i < myArr.Length; i++)
    {
        Console.Write($"Введите элемент массива {i} ");
        myArr[i] = Convert.ToInt32(Console.ReadLine());
     }
    return myArr;
}

//Вывод массива
void PrintArray(int[] arr)
{
    Console.WriteLine("Вывод массива:");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{myArray[i]} ");
    }
}

//Сколько элементов больше 0 ввёл пользователь
int PositiveNumbers(int[] arr)
 {
   int count = 0;
   for (int i = 0; i<arr.Length; i++)
   {
     if (arr[i] > 0)
     {
       count++;
     }
   }
   return count;
 }

int[] myArray1 = CreateArray(myArray);
int result = PositiveNumbers(myArray1);
PrintArray (myArray1);
Console.Write($"-> {result}");