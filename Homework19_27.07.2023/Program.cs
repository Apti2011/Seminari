//Задача 19. Напишите программу, которая принимает на вход пятизначное число
//и проверяет, является ли оно палиндромом.
//Пример 14212->нет 23432->да 12821->да
Console.WriteLine("Введите пятизначное число ");
int originalNumber = Convert.ToInt32(Console.ReadLine());
int remainder;
int reverseNumber = 0;
int tempNumber = originalNumber;

            if (originalNumber > 9999 && originalNumber <= 99999)
            {
                while (originalNumber > 0)
                {
                    remainder = originalNumber % 10;
                    reverseNumber = reverseNumber * 10 + remainder;
                    originalNumber = originalNumber / 10;
                }
                if (tempNumber == reverseNumber)
                {
                    Console.WriteLine("Да");//Введенное число является палиндромным числом
                }
                else Console.WriteLine("Нет");//Введенное число не является палиндромным числом
            }
            else Console.WriteLine("Введите пятизначное чиcло");

