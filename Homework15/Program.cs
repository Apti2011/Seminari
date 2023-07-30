//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.Write("Введите день недели ");
int number = Convert.ToInt32(Console.ReadLine());

if(number>5 && number <=7){
  Console.WriteLine("Да");
}
else if(number > 0 && number <= 5){
  Console.WriteLine("Нет");
}
else Console.WriteLine("Не является днем недели");
