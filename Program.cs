using System;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Первое домашнее задание.");
            float a,b,c,d;
            System.Console.WriteLine("Задача 1 :");
            System.Console.Write("а = ");
            a=float.Parse(Console.ReadLine());
            System.Console.Write("b = ");
            b=float.Parse(Console.ReadLine());
            Zadacha1(a,b);
            System.Console.WriteLine();
            System.Console.WriteLine("Задача 2 :");
            System.Console.Write("A = ");
            a=float.Parse(Console.ReadLine());
            System.Console.Write("B = ");
            b=float.Parse(Console.ReadLine());
            System.Console.Write("C = ");
            c=float.Parse(Console.ReadLine());
            Zadacha2(a,b,c);
            System.Console.WriteLine();
            System.Console.WriteLine("Задача 3 :");
            System.Console.Write("x1 = ");
            a=float.Parse(Console.ReadLine());
            System.Console.Write("y1 = ");
            b=float.Parse(Console.ReadLine());
            System.Console.Write("x2 = ");
            c=float.Parse(Console.ReadLine());
            System.Console.Write("y2 = ");
            d=float.Parse(Console.ReadLine());
            Zadacha3(a,b,c,d);
            System.Console.WriteLine();
            System.Console.WriteLine("Задача 4 :");
            System.Console.Write("Число : ");
            a=float.Parse(Console.ReadLine());
            Zadacha4((int)a);
            System.Console.WriteLine();
            System.Console.WriteLine("Задача 5 :");
            System.Console.Write("N = ");
            a=float.Parse(Console.ReadLine());
            Zadacha5((int)a);
            System.Console.WriteLine();
            System.Console.WriteLine("Задача 6 :");
            System.Console.Write("K = ");
            a=float.Parse(Console.ReadLine());
            Zadacha6((int)a);
            System.Console.WriteLine();
        }
        static void Zadacha1(float a, float b)=>Console.WriteLine($"результат = {MathF.Sqrt(a*b)}");
        static void Zadacha2(float a,float b,float c)
        {
            System.Console.WriteLine($"AC = {MathF.Abs(a-c)}");
            System.Console.WriteLine($"BC = {MathF.Abs(b-c)}");
            System.Console.WriteLine($"AC+BC = {MathF.Abs(MathF.Abs(a-c)+MathF.Abs(b-c))}");
        }
        static void Zadacha3(float x1,float y1,float x2,float y2)=>System.Console.WriteLine($"результат = {MathF.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1))}");
        static void Zadacha4(int num)=>System.Console.WriteLine($"Резултат : {num.ToString()[1]}{num.ToString()[0]}");
        static void Zadacha5(int seconds)=>System.Console.WriteLine($"Результат : {seconds/60}");
        static void Zadacha6(int days)=>System.Console.WriteLine($"Номер дня недели : {days%7}");
    }
}
 