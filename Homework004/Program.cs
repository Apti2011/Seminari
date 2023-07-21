//Задача 4: Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.
//пример 2,3,7->7

Console.WriteLine("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число ");
int number3 = Convert.ToInt32(Console.ReadLine());
int max=0;

if (number1 > max) max=number1;
if (number2 > max) max=number2;
if (number3 > max) max=number3;

Console.WriteLine($"Максимальное число из {number1} {""} {number2} и {number3} является {max}");


