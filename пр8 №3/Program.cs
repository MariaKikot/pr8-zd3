using System;
namespace Hello
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите значение координаты x=");
            float x = float.Parse(Console.ReadLine());
            Console.Write("Введите значение координаты y=");
            float y = float.Parse(Console.ReadLine());
            if (y <= -Math.Abs(x) && Math.Pow(x, 2) + Math.Pow(y, 2) < 25 && y < 0)
                Console.WriteLine("Точка (x,y) лежит внутри закрашенной области");
            else if (y > -Math.Abs(x) || Math.Pow(x, 2) + Math.Pow(y, 2) < 25 || y > 0)
                Console.WriteLine("Точка (x,y) лежит вне закрашенной области");
            else Console.WriteLine("Точка (x,y) лежит на границе закрашенной области");
        }
    }
}