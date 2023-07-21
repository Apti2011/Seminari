// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа
//в промежутке от -N до N. Например 4 -> "-4, -3, -2, -1, 0 1 2 3 4"
Console.WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
int i, j;

if(a==a)
{ 
for(i=-a; i<=a; i++)
Console.Write($"{i} ");
}
else if(a==-a);
for(j=a; j<=-a; j++)
Console.Write($"{j} ");

