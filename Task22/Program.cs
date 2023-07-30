//Задача 22: Напишите программу, которая
//принимает на вход число (N) и выдаёт таблицу
//квадратов чисел от 1 до N.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1)
{
    Console.WriteLine("Некорректные данные");
    return;
}
SquareTable(number);

void SquareTable(int num)
{
    for (int i = 1; i <= num; i++)
    {
        int square = i * i;
        Console.WriteLine($"{i, 3}{square, 5}");//3 и 5 пробелы
    }
}
 