//Напишите программу, которая принимает на вход трехзначное число и на выходе 
//показывает последнюю цифру этого числа, например 456 -> 6

Console.WriteLine("Введите трехзначное целое число");
int number = Convert.ToInt32(Console.ReadLine());

if(number < 0) 
{
  number *= -1;
}

if (number >= 100 && number <= 999)
{
int result = number % 10;
Console.WriteLine($"Последняя цифра числа: {result}");
}

else
{
  Console.WriteLine("Число не трехзначное");
}




