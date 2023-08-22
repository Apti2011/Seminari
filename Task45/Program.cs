//Задача 45: Напишите программу, которая будет создавать
//копию заданного массива с помощью поэлементного
//копирования.

int[] array = {1, 2 ,3};
Console.WriteLine("{0}", string.Join (" ", array));
int[] copyArr = CopyArr(array);
//copyArr[0] = 7;
Console.WriteLine("{0}", string.Join(" ", copyArr));

int[] CopyArr(int[] arr)
{
    int[] newArr = new int[arr.Length];
    for (int i =0; i< arr.Length; i++) 
        newArr[i] = arr[i];
    return newArr;
}

