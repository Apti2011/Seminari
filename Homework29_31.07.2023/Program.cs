//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] array=new int [8];
FillArr(array);
PrintArr(array);


void FillArr(int[] arr)
{
  Random rnd = new Random();
  for (int i =0; i<arr.Length; i++)
  {
    arr[i] = rnd.Next(-99, 99);//new Random().Next(2)
  }
}
void PrintArr(int[] arr){
  Console.Write("-> [ ");
  for (int i = 0; i<arr.Length; i++){
        Console.Write($"{arr[i]},");
        }
Console.Write(" ]");
}
