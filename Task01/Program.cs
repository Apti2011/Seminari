
//Напишите программу, которя на вход принимает два числа и проверяет, является ли первое число квадратом второго.
//Например a=25, b=5 -> да, a=2, b=10 -> нет и т.д.

Console.WriteLine("Введите первое число ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число ");
int b = Convert.ToInt32(Console.ReadLine());

if(a==b*b)
{
Console.WriteLine ($"Первое число {a} является квадратом второго числа {b}");
}
else if(a!=b*b)
{
Console.WriteLine ($"Первое число {a} не является квадратом второго числа {b}");
}

