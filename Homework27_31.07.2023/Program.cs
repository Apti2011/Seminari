//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
if(number < 0) 
{
  number *= -1;
}

int NumberSum(int num)
{
int sum=0;
while(num !=0){
int result = num % 10;
sum=sum+result;
num=num/10;
}
return sum;
}
int sum = NumberSum(number);
Console.WriteLine($"Сумма цифр числа {number} равна {sum}");
