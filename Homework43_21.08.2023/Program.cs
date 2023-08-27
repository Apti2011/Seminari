//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

//void CrossPoint(double k1, double b1, double k2, double b2)
void CrossPoint(double b1, double k1, double b2, double k2)
{
 double x=(b1-b2)/(k1-k2); 
 double y = k1 * x + b1;

if(k1==k2) Console.Write("Заданные прямые не пересекаются");
else
Console.Write($"Точка пересечения двух заданных прямых: ({x:F2}; {y:F2})");
}

Console.WriteLine("Введите точку b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите точку k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите точку b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите точку k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
CrossPoint(b1,k1,b2,k2);