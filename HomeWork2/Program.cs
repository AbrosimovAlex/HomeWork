// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*

Console.Clear();
void SecondNum(int number) 
{
    if(number < 100 || number > 999) Console.WriteLine("Число должно быть трехзначное, введите число от 100 до 999 ");
    else 
    { 
        number = (number / 10) % 10;
        Console.WriteLine(number);
    }
        
}

Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
SecondNum(num);

*/

// Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*

Console.Clear();
void ThirdDigit (int number) 
{
    if (number >= 1000) 
    {
        while (number > 1000) number = number / 10;
        int result = number % 10;
        Console.WriteLine(result);
    }
    else if (number < 1000 && number >= 100) 
    {
        int result = number % 10;
        Console.WriteLine(result);
    }
    else Console.WriteLine("Число не трехзначное, введите число от 100 до 999");
}

Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
ThirdDigit(num);

*/


// Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*

Console.Clear();
void FindDate (int day) 
{
    if(day >= 6 && day <= 7) Console.WriteLine("Выходной день!");
    else if (day <= 0 || day > 7) Console.WriteLine("Нет такого дня, введите число от 1 до 7");
    else Console.WriteLine("Будний день");
    
}

Console.Write("Введите число, соответствующее дню недели, от 1 до 7: ");
int num = Convert.ToInt32(Console.ReadLine());
FindDate(num);

*/