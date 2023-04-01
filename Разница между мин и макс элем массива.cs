/* Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива. [3 7 22 2 78] -> 76*/

void FillArray (double[] arr) //-----Создаём массив
{
    for (int ind = 0; ind < arr.Length; ind++)
    {
        arr[ind] = new Random().Next(1, 20);
    }
}

void PrintArray (double[] array) //------Печатаем массив
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine("]");
}

double DiffMaxMin (double[] mass)
{
    double dif = 0;
    double max = mass[0];
    double min = mass[0];
    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i] < min)
        min = mass [i];
        if (mass[i] > max)
        max = mass [i];
    }
    dif = max - min;
    return dif;
    
}

double[] Arr = new double [8];
FillArray (Arr);
PrintArray (Arr);
Console.WriteLine( DiffMaxMin (Arr));
