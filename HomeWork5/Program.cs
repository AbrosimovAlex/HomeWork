// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] RandomArr (int size)
{
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
        result[i] = new Random().Next(100,1000);
    return result;
}
int CountPositiv (int[] arr)
{
    int count = 0;
    for(int i = 0; i<arr.Length; i++)
        if(arr[i] % 2 == 0)
            count++;
    return count;
}
void PrintArray (int[] arr)
{
    for(int i = 0; i<arr.Length;i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

Console.Write("Input the array size: ");
int inputSize = Convert.ToInt32(Console.ReadLine());
int[] arr = RandomArr(inputSize);
PrintArray(arr);
int count = CountPositiv(arr);
Console.WriteLine($"Кол-во четных элементов в массиве: {count}");

*/


// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*

int[] RandomArr (int size)
{
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
        result[i] = new Random().Next(100,1000);
    return result;
}
void PrintArray (int[] arr)
{
    for(int i = 0; i<arr.Length;i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}
int SumOddNum (int[]arr)
{
    int sum = 0;
    for(int i = 1; i<arr.Length;i+=2)  
        sum += arr[i];
    return sum;
}

Console.Write("Input the array size: ");
int inputSize = Convert.ToInt32(Console.ReadLine());
int[] arr = RandomArr(inputSize);
PrintArray(arr);
int sum = SumOddNum(arr);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {sum}");

*/

// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


double[] CreateArray(int size, int min, int max)
{
    double[] array = new double[size];

    for (int i = 0; i < size; i++)    
        array[i] = new Random().Next(min, max) + new Random().NextDouble();
    
    return array;
    
}

double MinMaxDifference (double[] array)
{
   
    double min = array[0];
    double max = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if(array[i] < min)
            min = array[i];
        
        if (array[i] > max)
            max = array[i];
    }

     double dif = max - min;
     return dif;
}

void PrintArray (double[] arr)
{
    for(int i = 0; i<arr.Length;i++)
        Console.Write(arr[i] + "  ");
    Console.WriteLine();
}

Console.Write("Введите размер массива: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число массива: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число массива: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

double[] arr = CreateArray(number, minValue, maxValue);
PrintArray(arr);

Console.WriteLine("Разница между максимальных и минимальным значением: " + MinMaxDifference(arr));

