//11. Напишите программу, которая выводит случайное
//трёхзначное число и удаляет вторую цифру этого
//числа.
//456 -> 46
//782 -> 72
//918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трёхзначное число из отрезка 100 - 999 -> {number}");

int result = Digit(number);
Console.WriteLine ($"число состоящее из первой и последней цифры {result}");

int Digit (int num)
{
  int Digit=(num/100*10)+(num%10);
  
  return Digit;
}
