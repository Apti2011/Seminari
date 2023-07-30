//14. Напишите программу, которая принимает на
//вход число и проверяет, кратно ли оно
//одновременно 7 и 23.
//14 -> нет
//46 -> нет
//161 -> да

Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

int result1 = number % 7;
int result2 = number % 23;
if (result1==0 && result2 ==0) Console.WriteLine("да");
else Console.WriteLine("неn");