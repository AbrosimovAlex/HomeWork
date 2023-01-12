// Напишите программу который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*

int MathPow (int num, int pow)                 
{
    int resualt = 1;                           // int result = Convert.ToInt32(Math.Pow(num, pow));
    for(int i = 1; i <= pow; i++)
    {
        resualt = resualt*num;
    }
    return resualt;
}


Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("В какую степень возводим число?: ");
int pow = Convert.ToInt32(Console.ReadLine());

int newNum = MathPow(num,pow);
Console.WriteLine(newNum);

*/

// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*

int SumNums ( int inputNumber)  
{
    int sum = 0;
    while(inputNumber != 0)
    {
        sum += (inputNumber % 10); 
        inputNumber /=  10;
    }
    return sum;

}

Console.Write("Введите число: ");
int inputNum = Convert.ToInt32(Console.ReadLine());
int result = SumNums(inputNum);
Console.WriteLine(result);

*/

// Напишите программу, которая задаёт массив из m элементов и выводит их на экран
/*

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = InputNumber();
    }
    return array;
}
int InputNumber()
{
    Console.WriteLine("Введите цифру для массива: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
void GetArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
Console.WriteLine("Введите размер массива: ");
int[] array = CreateArray(Convert.ToInt32(Console.ReadLine()));
Console.Write($"Массив: ");
GetArray(array);

*/
