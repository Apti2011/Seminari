//Задача 65: Задайте значения M и N. Напишите программу, которая
//выведет все натуральные числа в промежутке от M до N.
//M = 1; N = 5 -> "1, 2, 3, 4, 5"
//M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.WriteLine("Введите натуральное число 1: "); int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число 2: "); int numberN = Convert.ToInt32(Console.ReadLine());
if (numberM < 1 || numberN < 1) { Console.WriteLine("Не корректный ввод: "); return; }

RangNaturalNumbers(numberM, numberN);

void RangNaturalNumbers(int numM, int numN)
{
  if (numM > numN)
  {
    Console.Write($"{numM} ");
    RangNaturalNumbers(numM - 1, numN);
  }
  else if (numM < numN)
  {
    Console.Write($"{numM} ");
    RangNaturalNumbers(numM + 1, numN);
  }
  else { Console.Write($"{numM} "); }
}
