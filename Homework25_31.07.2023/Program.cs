///Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.WriteLine("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
if(number1 < 0) 
{
  number1 *= -1;
}
Console.WriteLine("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());
if(number2 < 0) 
{
  number2 *= -1;
}

int exponent=number1;

for(int i = 1; i<number2; i++){
exponent=exponent*number1;
Console.WriteLine(exponent);
}

