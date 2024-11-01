using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите значение a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите значение b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите шаг h: ");
        double h = Convert.ToDouble(Console.ReadLine());

        if (h <= 0 || a >= b)
        {
            Console.WriteLine("Ошибка: Некорректные значения a, b или h.");
            return;
        }

        int pointsCount = (int)((b - a) / h) + 1;

        Console.WriteLine("\n Таблица значений \n");
        Console.WriteLine($"{"x",-10} {"y(x)",-20}");
        Console.WriteLine(new string('-', 30));

        for (double x = a; x <= b; x += h)
        {
            double y = Math.Cos(x * x) + Math.Sin(x) * Math.Sin(x);
            Console.WriteLine($"{x,-10:F2} {y,-20:F5}");
        }

        Console.WriteLine($"\nКоличество точек в таблице: {pointsCount}");
    }
}
