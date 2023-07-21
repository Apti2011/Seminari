// Задача 8: Напишите программу, которая на вход принимает число (N),
//а на выходе показывает все четные числа от 1 до N, например: 5 ->2, 4. 8->2,4,6,8.

Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int counter;
Console.WriteLine($"Все четные из числа {number}");
for (counter = 1; counter <= number; counter++) {
		if (counter % 2 != 0);
		else if (counter% 2 == 0) 
    Console.Write(counter);
    Console.Write(" ");
	}