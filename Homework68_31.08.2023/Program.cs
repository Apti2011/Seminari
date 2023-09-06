//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3->A(m, n) = 9
//m = 3, n = 2->A(m, n) = 29


Console.WriteLine("Введите число m:");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число n:");
int numberN = Convert.ToInt32(Console.ReadLine());

int AckermanFunctions(int numM, int numN)
{
    if (numM == 0) return numN + 1;
    else if (numN == 0) return AckermanFunctions(numM - 1, 1);
    else return AckermanFunctions(numM - 1, AckermanFunctions(numM, numN - 1));
}

Console.Write($"Вычисление функции Аккермана из двух неотрицательных чисел {numberM} и {numberN} = {AckermanFunctions(numberM, numberN)} ");