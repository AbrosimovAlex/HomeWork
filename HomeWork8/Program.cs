//  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*

int[,] Create2dArray()
{
    Console.Write("Input a count of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a count of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a minValue: ");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a maxValue: ");
    int maxVal = Convert.ToInt32(Console.ReadLine());

    int[,] matrix = new int [rows,columns];

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(minVal,maxVal+1);
        }
    }
    return matrix;

}

void Print2dArrau (int[,] matrix)
{
    Console.WriteLine("------------------------------");
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

void Sort2dArray (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            for (int k = 0; k < matrix.GetLength(1) - 1; k++)
            {
                if (matrix[i, k] < matrix[i, k + 1]) 
                {
                    int temp = matrix[i, k];
                    matrix[i, k] = matrix[i, k + 1];
                    matrix[i, k + 1] = temp;
                }
            }
        }
    }
}


int[,] matrix = Create2dArray();
Print2dArrau(matrix);
Sort2dArray(matrix);
Print2dArrau(matrix);

*/

// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*

int[,] Create2dArray()
{
    Console.Write("Input a count of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a count of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a minValue: ");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a maxValue: ");
    int maxVal = Convert.ToInt32(Console.ReadLine());

    int[,] matrix = new int [rows,columns];

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(minVal,maxVal+1);
        }
    }
    return matrix;

}

void Print2dArray (int[,] matrix)
{
    Console.WriteLine("------------------------------");
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

void MinSumOfArrayRows (int[,] matrix)
{
    int minsum = Int32.MaxValue;
    int indexRow = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];        
        } 
        Console.WriteLine($"The sum of {i+1} row ----> {sum}");
        if (sum < minsum)
        {
            minsum = sum;
            indexRow = i+1;
        }
    }
    Console.WriteLine("Row with a min sum of elements: " + (indexRow) + ", the sum of row: " + (minsum));
}


int[,] matrix = Create2dArray();
if(matrix.GetLength(0) != matrix.GetLength(1)) 
{
    Print2dArray(matrix);
    MinSumOfArrayRows(matrix);
}
else Console.WriteLine("Array is not a rectangular");

*/

// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*

int[,] FillMatrixRandomNumbers(int size)
{
    int[,] matrix = new int[size, size];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1,10); 
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
Console.WriteLine("Input a matrix size: ");
int size = Convert.ToInt32(Console.ReadLine());
int[,] matrixA = FillMatrixRandomNumbers(size);
int[,] matrixB = FillMatrixRandomNumbers(size);
int[,] matrixC = new int[size, size];

for (int i = 0; i < size; i++)
{
    for (int j = 0; j < size; j++)
    {
        for (int k = 0; k < size; k++)
        {
            matrixC[i, j] += (matrixA[i, k] * matrixB[k, j]);
        }
    }
}
Console.WriteLine("Matrix - A");
PrintMatrix(matrixA);
Console.WriteLine();
Console.WriteLine("Matrix - B");
PrintMatrix(matrixB);
Console.WriteLine();
Console.WriteLine("Product of A*B numbers");
PrintMatrix(matrixC);

*/

// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*

int[,,] Set3dArray(int[] numberset, int rows, int columns, int layers) //Filling the 3D Array with Uniq numbers
{
    int[,,] mas = new int[rows, columns, layers];
    int l = 0;
    for (int k = 0; k < layers; k++)
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < columns; j++)
            {
                mas[i, j, k] = numberset[l];
                l++;
            }
    return mas;
}
int[] GenNumSet(int size)// Generating uniq numbers set for 3D Array fill, MAX = 90 numbers
{
    int[] seq = new int[size];
    for (int i = 0; i < size; i++)
    {
        bool ok = false;
        int num = 0;
        while (!ok)
        {
            num = new Random().Next(10, 100);
            int k = 0;
            for (int j = 0; j < i; j++)
                if (seq[j] != num) k++;
            if (k == i) ok = true;
            else ok = false;
        }
        seq[i] = num;
    }
    return seq;
}
int InputGen(string message)
{
    Console.Write(message + " = ");
    return Convert.ToInt32(Console.ReadLine());
}
void Show3dArray(int[,,] mas)// Show the 3D Array layer-by-layer
{
    for (int k = 0; k < mas.GetLength(2); k++)
    {
        Console.WriteLine($"=== Layer {k + 1} ===");
        for (int i = 0; i < mas.GetLength(0); i++)
        {
            for (int j = 0; j < mas.GetLength(1); j++)
            {
                if (j != mas.GetLength(1) - 1) Console.Write($"{mas[i, j, k]} : ");
                else Console.Write($"{mas[i, j, k]}");
            }
            Console.WriteLine();
        }
    }
}
bool CheckNumQuantity(int rows, int columns, int layers) // max 90 numbers consist from 2 digits
{
    return (rows * columns * layers) <= 90;
}
Console.Clear();
Console.WriteLine("Program 3d Array fill with uniq 2-digits numbers");
int rows = InputGen("Please, input Rows of 3d Array");
int columns = InputGen("Please, input Columns of 3d Array");
int layers = InputGen("Please, input Layers of 3d Array");
if (CheckNumQuantity(rows, columns, layers))//Check if Arrays dimensions are not out of 2-digits set
{
    int[] numbers = GenNumSet(rows * columns * layers);
    Console.WriteLine($"3d Array [{rows} , {columns} , {layers}] has = {numbers.Length} elements");
    Show3dArray(Set3dArray(numbers, rows, columns, layers));
}
else
{
    Console.WriteLine($"Sorry, but Array of [{rows} , {columns} , {layers}] = {rows * columns * layers} elements.");
    Console.WriteLine("Maximum elements quantity is 90 (2-digits numbers)");
}

*/

// Напишите программу, которая заполнит спирально массив А на В
/*

void Print2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int cols = 0; cols < array.GetLength(1); cols++)
            Console.Write(array[i, cols] + "\t");

        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] CreateSpiralMatrix(int rows, int cols)
{
    int[,] array = new int[rows, cols];
    
    int iBegin = 0, iEnd = 0, jBegin = 0, jEnd = 0;
    int i = 0;
    int j = 0;
    
    for (int k = 0; k < array.Length; k++)
    {
        array[i, j] = k + 1;
        if (i == iBegin && j < array.GetLength(1) - jEnd - 1)
            j++;
        else if (j == array.GetLength(1) - jEnd - 1 && i < array.GetLength(0) - jEnd - 1)
            i++;
        else if (i == array.GetLength(0) - jEnd - 1 && j > jBegin)
            j--;
        else
            i--;

       if ((i == iBegin + 1) && (j == jEnd) && (jEnd != array.GetLength(1) - jEnd - 1))
       {
            iBegin++;
            iEnd++;
            jBegin++;
            jEnd++;
        }
    }
    
    return array;
}

Console.Write("Input the number of rows: ");
int numX = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the number of columns: ");
int numY = Convert.ToInt32(Console.ReadLine());
int[,] myArray = CreateSpiralMatrix(numX, numY);
Print2dArray(myArray);

*/