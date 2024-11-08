﻿using System;
using System.Text;

class Program
{
    static void Main()
    {
        // Ввод числа x в 10-чной системе счисления
        Console.Write("Введите число x в 10-чной системе счисления: ");
        int x = int.Parse(Console.ReadLine());

        // Ввод основания системы счисления q
        Console.Write("Введите основание системы счисления q (от 2 до 9): ");
        int q = int.Parse(Console.ReadLine());

        // Проверка корректности введенного основания
        if (q < 2 || q > 9)
        {
            Console.WriteLine("Ошибка: основание системы счисления должно быть в диапазоне от 2 до 9.");
            return;
        }

        // Преобразование числа x в систему счисления q
        string result = ConvertToBase(x, q);

        // Вывод результата
        Console.WriteLine($"Число {x} в {q}-чной системе счисления: {result}");
    }

    static string ConvertToBase(int number, int baseSystem)
    {
        if (number == 0)
            return "0";

        StringBuilder sb = new StringBuilder();

        while (number > 0)
        {
            int remainder = number % baseSystem;
            sb.Insert(0, remainder);
            number /= baseSystem;
        }

        return sb.ToString();
    }
}