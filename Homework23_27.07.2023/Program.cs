// Задача 23 Напишите программу которая принимает на вход число (N) и выдает таблицу кубов чисел от 1 до N.
//Пример  -> 1, 8, 27

Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

if(number<1){
   Console.WriteLine("Некорректные данные");
    return;
}

NumberCube(number);
void NumberCube(int num)
{
for(int i = 1; i<=num; i++){
   int numCube=i*i*i;
   Console.WriteLine($"{i, 3}{numCube, 5}");
}
}
