//12. Напишите программу, которая будет принимать на
//вход два числа и выводить, является ли первое число
//кратным второму. Если первое число не кратно
//второму, то программа выводит остаток от деления.
//34, 5 -> не кратно, остаток 4
//16, 4 -> кратно

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int result=Remainder(number1, number2);
if(result==0) Console.WriteLine($"Первое число {number1} кратно второму числу {number2}");
else Console.WriteLine($"Первое число {number1} не кратно второму числу {number2}, остаток {result}");

int Remainder(int num1, int num2)
{
int Remainder = num1%num2;
return Remainder;
}



