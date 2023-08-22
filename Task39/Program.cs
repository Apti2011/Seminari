//Задача 39: Напишите программу, которая перевернёт
//одномерный массив (последний элемент будет на первом
//месте, а первый - на последнем и т.д.)

//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]

int[] CreateArrayRndInt(int size, int min, int max)//метод, для создания и заполнения цикла случайными числами
{
    int[] arr = new int[size];//создаем массив, по умалчанию массив заполнен нулями
    Random rnd = new Random();//создаем объект Random и внутри цикла его использовать

    for (int i = 0; i < arr.Length; i++)//цикл для прохода по всем элементам массива
    {
        arr[i] = rnd.Next(min, max + 1);//заплняем массив случайными числами
    }
    return arr; //возврат массива
}

void PrintArray(int[] arr)//Метод(функция) для вывода массива в консоль
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

//[1 2 3 4 5] -> [5 4 3 2 1]
//метод разворота массива
void ReverseArray(int[] arr)
{
for(int i=0; i<arr.Length/2; i++)//2 итерации первый и последний, второй и предпоследний элементы массива меняем местами, поэтому делим на два arr.Length/2
{
  int temp=arr[i];//temp временная переменная для замены элементов в массиве, сохраняем значени первого элемента arr[0]
  arr[i]=arr[arr.Length-1-i];//присваиваем значение правого элемента, [arr.Length-1-i] последний элемент массива
  arr[arr.Length-1-i]=temp;//последнему элементу arr[arr.Length-1-i] присваиваем значение первого элемента temp
}
}

int[] array = CreateArrayRndInt(5, 1, 9);
PrintArray(array);
Console.WriteLine();

ReverseArray(array);
PrintArray(array);
Console.WriteLine();

//Array.Reverse(array);
//PrintArray(array);