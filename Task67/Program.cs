//Задача 67: Напишите программу, которая будет 
//принимать на вход число и возвращать сумму его цифр.
//453 -> 12
//45 -> 9

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumOfDigits(int num)//453 --> 45-->4-->0
{
    if (num == 0) return 0;
    return num % 10 + SumOfDigits(num/10);// Сохраняется  зн-е 453-->45-->4
}// 0 + 4 % 10 + 45 % 10 + 453 % 10

Console.WriteLine(SumOfDigits(number));

