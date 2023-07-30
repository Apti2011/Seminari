//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
//на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

//Console.WriteLine("Введите трехзначное число");
//int number = Convert.ToInt32(Console.ReadLine());
//if(number < 0) 
//{
  //number *= -1;
//}
//if (number>=100 && number <=999) {
  //int result = number / 10 % 10;
  //Console.WriteLine($"Второе число из {number} является {result}");
  //}
//else Console.WriteLine ($"Число {number} не трехзначно");
 
int Digit(int num){
  int Digit = num / 10 % 10;
  return Digit;
  }
Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

if(number < 0) 
{
  number *= -1;
}
int result = Digit(number);
if (number>=100 && number <=999) {
  Console.WriteLine($"Второе число из {number} является {result}");
  }
else Console.WriteLine ($"Число {number} не трехзначно");

