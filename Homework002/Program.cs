﻿//Задача 2: Напишите программу, которая на вход принимает два числа и выдает, 
//какое число большее, а какое меньшее Пример:a=5; b=7 -> max=7

Console.WriteLine("Введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2){
  Console.WriteLine($"Число {number1} больше числа {number2}");
}
else if (number1 < number2){
  Console.WriteLine($"Число {number2} больше числа {number1}");
}

