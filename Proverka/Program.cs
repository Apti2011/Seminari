//ЗАПОЛНИТЬ МАССИВ С КЛАВИАТУРЫ 
Console.Write("Введите количество элементов массива: ");
int elementsCount = Convert.ToInt32(Console.ReadLine());
int[] myArray = new int[elementsCount];

for(int i =0; i < myArray.Length; i++)
{
  Console.Write($"Введите элемент массива под индексом {i} ");
  myArray[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Вывод массива:");
for (int i = 0; i < myArray.Length; i++)
{
  Console.Write($"{myArray[i]} ");
 
}