﻿//Напишите программу, которая выводит
//случайное число из отрезка [10, 99] и показывает
//наибольшую цифру числа.
//78 -> 8
//12-> 2
//85 -> 8

int number = new Random().Next(10, 100);//99+1
Console.WriteLine($"Случайное число из отрезка 10 - 99 -> {number}");

//int firstDigit = number / 10;
//int secondDigit = number % 10;

//if(firstDigit>secondDigit) Console.WriteLine($"Наибольшая цифра числа -> {firstDigit}");
//else Console.WriteLine($"Наибольшая цифра числа -> {secondDigit}");

//int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;//тернарный оператор. ? -тогда и : иначе.
//Console.WriteLine($"Наибольшая цифра числа -> {maxDigit}");

int result = MaxDigit(number);// вызов функции (метода)
Console.WriteLine($"Наибольшая цифра числа -> {result}");

int MaxDigit(int num)
{
int firstDigit = num / 10;
int secondDigit = num % 10;
int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;//тернарный оператор. ? -тогда и : иначе.
return maxDigit;
}