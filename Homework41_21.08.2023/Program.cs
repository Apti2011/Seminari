//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите первый элемент массива ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второй элемент массива ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третий элемент массива ");
int number3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите четвертый элемент массива ");
int number4 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите пятый элемент массива ");
int number5 = Convert.ToInt32(Console.ReadLine());

int[] array = {number1, number2, number3, number4, number5};

int CountPositiveNumbers(int[] arr)
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

int result = CountPositiveNumbers (array);
Console.Write (string.Join (" ", array));
Console.Write ($"-> {result}");
