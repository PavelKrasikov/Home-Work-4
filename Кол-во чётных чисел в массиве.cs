//Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве [345, 897, 568, 234] -> 2

void FillArray (int[] arr) //-----Создаём массив
{
    for (int ind = 0; ind < arr.Length; ind++)
    {
        arr[ind] = new Random().Next(100, 1000);
    }
}

void PrintArray (int[] array) //------Печатаем массив
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine("]");
}

int ShowDigit (int[] mass)
{
    int count = 0;
    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i]%2 == 0)
       {
        count = count + 1;
       }
    }
    return count;
}

int[] Arr = new int [8];
FillArray (Arr);
PrintArray (Arr);
Console.WriteLine("Количество чётных чисел вмассиве " + ShowDigit (Arr));
