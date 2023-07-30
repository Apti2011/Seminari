//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int result = 1;

if(number < 0) 
{
  number *= -1;
}

if(number >= 100){
while (number > 999) {
number=number/10;
}
  result = number % 10;
}

if (number <=99)
Console.WriteLine("Tретьей цифры нет");
else
Console.WriteLine($"Третья цифра {result}");
