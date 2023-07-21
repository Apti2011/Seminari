// Задача 6: Напишите программу, которая на вход принимает число и выдает,
//является ли число четным (делится ли оно на два без остатка)
//Например: 4 -> да, -3 -> нет.

Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 != 0) 
{
   Console.WriteLine($"{number} не является четным числом");
  }
else if (number % 2 == 0) 
{  
Console.WriteLine($"{number} является четным числом");
}
