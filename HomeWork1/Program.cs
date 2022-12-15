// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*

Console.Write("Напишите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Напишите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 == num2)
    Console.Write($"Число {num1} и число {num2}, одинаковы ");
else
    if(num1 > num2)
    Console.Write($"Число {num1} больше, чем число {num2}");
    else
    Console.Write($"Число {num2} больше, чем число {num1}");

*/



// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*

Console.Write("Напишите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Напишите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Напишите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if(num1 > num2)
    max = num1;
else
    max = num2;
if(max > num3)
    Console.WriteLine($"Максимальное число из введеных: {max}");
else
    Console.WriteLine($"Максимальное число из введеных: {num3}");

*/



// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*

Console.Write("Напишите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num % 2 == 0)
    Console.WriteLine("Введенное число четное");
else
    Console.WriteLine("Введенное число не четное");

*/




// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*

Console.Write("Напишите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int cur = 1;

if(num % 2 == 0)
{
    if(cur < num)
    {    
        cur += 1;
        while(cur <= num)
        {
            Console.Write(cur + ",");
            cur += 2;
        }
    }
    else
    {
        cur -= 1;
        while(cur >= num)
        {
            Console.Write(cur + ",");
            cur -= 2;
        }
    }

}
else
{
    if(cur > num)
    {
        cur -= 1;
        while(cur >= num)
        {
            Console.Write(cur + ",");
            cur -= 2;
        }
    }
    else
    {
        cur += 1;
        while(cur <= num)
        {
            Console.Write(cur + ",");
            cur += 2;
        }
    }
}

*/