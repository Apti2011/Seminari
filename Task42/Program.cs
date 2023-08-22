//Задача 42: Напишите программу, которая будет преобразовывать
//десятичное число в двоичное.
//46 -> 101110
//13 -> 1101
//2 -> 10

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(ConvertDecToBin(number));

int ConvertDecToBin(int num)
{
    int outNum = 0;
    int i = 1;
    while (num > 0)
    {
        outNum += num % 2 * i;
        i*=10;
        num /= 2;
    }
    return outNum;
}

// 13
// 13 % 2 = 1 * 1 = 1; 13 / 2 = 6; i = 10
// 6 % 2 = 0 * 10 = 0; 6 / 2 = 3; i = 100
// 3 % 2 = 1 * 100 = 100; 3 / 2 = 1; i = 1000
// 1 % 2 = 1 * 1000 = 1000; 1 / 2 = 0; i = 10000
// 1 + 0 + 100 + 1000 = 1101
