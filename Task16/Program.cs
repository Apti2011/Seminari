//16. Напишите программу, которая принимает на
//вход два числа и проверяет, является ли одно
//число квадратом другого.
//5, 25 -> да
//-4, 16 -> да
//25, 5 -> да
//8,9 -> нет

bool Square(int number1, int number2)
{
  return number1 == number2 * number2 || number2 == number1 * number1;
}

Console.WriteLine("Введите число1");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число2");
int b = Convert.ToInt32(Console.ReadLine());

bool result = Square(a, b);
Console.WriteLine(result ? "Да" : "Нет");

//Console.WriteLine("Введите первое число: ");
//int number1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите второе число: ");
//int number2 = Convert.ToInt32(Console.ReadLine());
//bool result = IsSquare(number1, number2);
//Console.WriteLine(result? "да" : "нет");
//bool IsSquare (int num1, int num2)
//{
//int result1 = num1*num1;
//int result2 = num2*num2;
//return result1==num2 || result2==num1;
//}