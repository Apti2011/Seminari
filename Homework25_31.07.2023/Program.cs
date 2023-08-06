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

NumberExponent(number1, number2);
void NumberExponent(int num1, int num2)
{
long exponent=num1;
for(int i = 1; i<num2; i++){
exponent=exponent*num1;
}
Console.WriteLine($"Число {num1} в {num2} степени равно {exponent}");
}