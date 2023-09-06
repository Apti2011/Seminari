//Задача 69: Напишите программу, которая на вход принимает два числа A и B, 
//и возводит число А в целую степень B с помощью рекурсии.
//A = 3; B = 5 -> 243 (3⁵)
///A = 2; B = 3 -> 8
Console.WriteLine("Введите первое целое число:");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе натуральное число:");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberB < 0)
{
    Console.WriteLine("Это число не подходит , введите число большее или равное 0");
    return;
}

int PowNum(int numA, int numB)
{
    if (numB == 0) return 1;
    return numA * PowNum(numA, numB - 1);
}

int powNum = PowNum(numberA, numberB);
System.Console.WriteLine(powNum);


