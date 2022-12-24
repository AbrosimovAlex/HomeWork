// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*

void Palindrom(int num)
{
   int oldnum = num;      
   int newnum = 0;   
   while(num > 0)
   {
      int ost = num % 10 ;
      newnum = newnum * 10 + ost;
      num = num / 10;
   }
   if(newnum == oldnum) Console.WriteLine("Палиндром");
   else Console.WriteLine("Не палиндром");
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Palindrom(num);

*/


// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*

double DisPoint(double xa, double ya, double za, double xb, double yb, double zb)
{
    double distance = Math.Sqrt(Math.Pow(xb-xa, 2) + Math.Pow(yb-ya, 2) + Math.Pow(zb-za, 2));
    return Math.Round(distance, 3);
}
Console.Write("Координаты точки А на оси X: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Координаты точки А на оси Y: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Координаты точки А на оси Z: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Координаты точки B на оси X: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Координаты точки B на оси Y: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Координаты точки B на оси Z: ");
double z2 = Convert.ToDouble(Console.ReadLine());

double disPoints = DisPoint(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Дистанция между точкой А({x1};{y1};{z1}) и точкой В({x1};{y1};{z1}) составляет - {disPoints}");

*/


// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*

void Kub(int num)
{
   int count = 1;
   while (count <= num)                                       
   {
      double fact = Math.Pow(count,3);
      Console.WriteLine($"Куб числа {count} > {fact}");
      count++;
   }
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Kub(num);

*/




