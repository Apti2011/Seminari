//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15-> 120
//M = 4; N = 8. -> 30

Console.WriteLine("Введите первое целое число:");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе натуральное число:");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM > numberN)
{
    int temp = numberM;
    numberM = numberN;
    numberN = temp;
}

int SumElements(int numM, int numN)
{
    if (numN == numM) return numN;
    
    return numN + SumElements(numM, numN-1);
}

int sumElements = SumElements(numberM, numberN);
System.Console.WriteLine(sumElements);
