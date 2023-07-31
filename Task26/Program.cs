//Задача 26: Напишите программу, которая принимает
//на вход число и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5
Console.WriteLine("Введите натуральное число");
int number= Convert.ToInt32(Console.ReadLine());

int result = CountNumberDigit(number);
Console.WriteLine($"Колличество цифр в числе {number} ={result}");

int CountNumberDigit(int num)
{
int countDigit =0;
while(num != 0)
{
  countDigit++;
  num = num/10;
}
return countDigit;
}