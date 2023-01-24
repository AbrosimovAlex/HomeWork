// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*

double[,] Create2dArray()
{
    Console.WriteLine("Input a count of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a count of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a min number of array: ");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a max number of array: ");
    int maxVal = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    double[,] array = new double[rows,columns];

    for ( int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i,j] = + Math.Round(new Random().NextDouble(),2) + new Random().Next(minVal,maxVal + 1);
    return array;
}

void Print2dArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0);i++)
    {
        for(int j = 0; j < array.GetLength(1);j++)
            Console.Write(array[i,j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
        
}

double[,] array = Create2dArray();
Print2dArray(array);

*/

// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
/*

int[,] Create2dArray()
{
    Console.WriteLine("Input a count of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a count of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a min number of array: ");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a max number of array: ");
    int maxVal = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    int[,] array = new int[rows,columns];

    for ( int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minVal,maxVal + 1);
    return array;
}

void Print2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0);i++)
    {
        for(int j = 0; j < array.GetLength(1);j++)
            Console.Write(array[i,j] + "\t");
        Console.WriteLine();
    }
    Console.WriteLine();
        
}

void FindElementOf2dArray (int[,] array)
{
    Console.WriteLine();
    Console.WriteLine("Lets find a element of index");
    Console.Write("Input rows index: ");
    int rowIndex = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input column index: ");
    int columnIndex = Convert.ToInt32(Console.ReadLine());

    if (rowIndex < array.GetLength(0) && columnIndex < array.GetLength(1)) 
        Console.WriteLine($"Элемент индекса '{rowIndex}' и '{columnIndex}': " + array[rowIndex,columnIndex] );
    else Console.WriteLine($"Элемента с индексом  '{rowIndex}' и '{columnIndex}', не существует");
}

int[,] array = Create2dArray();
Console.WriteLine("Ваш массив: ");

Print2dArray(array);
FindElementOf2dArray(array);

*/

// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*

int[,] Create2dArray()
{
    Console.WriteLine("Input a count of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a count of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a min number of array: ");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a max number of array: ");
    int maxVal = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    int[,] array = new int[rows,columns];

    for ( int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i,j] = new Random().Next(minVal,maxVal + 1);
    return array;
}

void Print2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0);i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        
        Console.WriteLine();
    }
    Console.WriteLine("----------------------------"); 
}

void ArithmeticMeanOfColumns(int[,] array)
{
    for(int i = 0; i < array.GetLength(1);i++)
    {
        double sum = 0;
        for(int j = 0; j < array.GetLength(0); j++) 
            sum += array[j,i];
        sum = Math.Round((sum /= array.GetLength(0)),2);
        Console.Write(sum + "\t");
    }
    Console.WriteLine();
        
}


int[,] array = Create2dArray();
Print2dArray(array);
ArithmeticMeanOfColumns(array);

*/
