// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 
/*

int PositivCount(int numbersCount) 
{ 
    int count = 0; 
    int num = 0; 
    for(int i = 1; i <= numbersCount; i++) 
    { 
        Console.WriteLine($"Введите {i} число: "); 
        num = Convert.ToInt32(Console.ReadLine()); 
        if (num > 0) count++; 

    } 
return count; 

} 

Console.Write("Введите количество чисел: "); 
int numbersCount = Convert.ToInt32(Console.ReadLine()); 
int count = PositivCount(numbersCount); 
Console.WriteLine($"Количество элементов больше 0 = {count}"); 

*/

// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, + k1, b2 и k2 задаются пользователем. 
/*

void IntersectionPoint(double k1, double b1, double k2, double b2) 
{ 

    if (k1 == k2) Console.WriteLine("Линии паралельны "); 
    if (k1 == k2 && b1 == b2) Console.WriteLine("Линии равны"); 
    if (k1 != k2 && b1 == b2) Console.WriteLine($"Координаты пересечения ({0}; {b1})"); 
    else 
    { 
        double x = (b1 - b2) / (k2 - k1); 
        double y = k1 * x + b1; 
        Console.WriteLine($"Координаты пересечения ({x}; {y})"); 
    } 
} 

Console.Write("Введите первую точку прямой А: "); 
double k1 = Convert.ToDouble(Console.ReadLine()); 
Console.Write("Введите вторую точку прямой А: "); 
double b1 = Convert.ToDouble(Console.ReadLine()); 
Console.Write("Введит первую точку прямой В: "); 
double k2 = Convert.ToDouble(Console.ReadLine()); 
Console.Write("Введит вторую точку прямой В: "); 
double b2 = Convert.ToDouble(Console.ReadLine()); 

IntersectionPoint(k1, b1, k2, b2);

*/