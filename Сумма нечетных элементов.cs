/* Найти сумму нечетных элементов массива */

void FillArray (int[] arr) //-----Создаём массив
{
    for (int ind = 0; ind < arr.Length; ind++)
    {
        arr[ind] = new Random().Next(0, 5);
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

int PrintSum (int[] mass)
{
    int Sum = 0;
    int length = mass.Length;
    for (int i = 0; i < length; i++)
    {
        if (i % 2 != 0)
        Sum = Sum + mass[i];
    }
    return Sum;
}

int[] Arr = new int [8];
FillArray (Arr);
PrintArray (Arr);
Console.WriteLine("Сумма чисел нечётных индексов = " + PrintSum (Arr));

