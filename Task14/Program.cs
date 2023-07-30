//14. Напишите программу, которая принимает на
//вход число и проверяет, кратно ли оно
//одновременно 7 и 23.
//14 -> нет
//46 -> нет
//161 -> да

bool Multiplicity(int number){
  return number % 7 == 0 && number % 23 == 0;
}
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

bool result = Multiplicity (a);
Console.WriteLine(result ? "Да":"Нет");

//Console.WriteLine("Введите число: ");
//int number = Convert.ToInt32(Console.ReadLine());

//int result1 = number % 7;
//int result2=number % 23;


//if(result1==0 && result2 == 0){
//Console.WriteLine($"Число {number} кратно 7 и 23");
//}
//else if(result1!=0 && result2 != 0){
//  Console.WriteLine($"Число {number} не кратно 7 и 23");
//}
//else if(result1==0 && result2 != 0){
//  Console.WriteLine($"Число {number} кратно 7 и не кратно 23");
//}
//else if(result1!=0 && result2 == 0){
//  Console.WriteLine($"Число {number} не кратно 7 и кратно 23");
//}



