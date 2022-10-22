﻿// Напишите программу, которая принимает на вход координаты точки (X и Y), причем х != 0 и у != 0
// и выдает номер четверти плоскости, в которой находится эта точка.

// ------------------------------Начало программы------------------------------------------------
Console.Clear();
int X = 0, Y = 0;

InitCoordinatesByUser(ref X, ref Y); // Вызов методов с передачей параметровв по ссылке (ref)
PrintQuarterByCoords(X, Y);          // Вызов методов с передачей параметровв по значению
// ------------------------------Конец программы------------------------------------------------

// ------------------------------Определение методов--------------------------------------------

// ---------------------------------------------------------------------------------------------
// Определяем функцию, выполняющую ввод значений координат
static void InitCoordinatesByUser(ref int x, ref int y)
{
    try
    {
        Console.Write("Введите Х: ");
        x = int.Parse(Console.ReadLine() ?? "");

        Console.Write("Введите Y: ");
        y = int.Parse(Console.ReadLine() ?? "");
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        return;
    }
}

// ---------------------------------------------------------------------------------------------
// Определяем функцию, принимающую двв аргумента (координаты точки х и у)
// и выводящую в консоль номер четверти плоскости, в которой находится точка
static void PrintQuarterByCoords(int x, int y)
{
    if (x > 0 && y > 0)
    {
        Console.WriteLine("1");
    }
    else if (x > 0 && y < 0)
    {
        Console.WriteLine("2");
    }
    else if (x < 0 && y < 0)
    {
        Console.WriteLine("3");
    }
    else if (x > 0 && y < 0)
    {
        Console.WriteLine("4");
    }
    else
    {
        Console.WriteLine("Ошибка! Точка попадает на оси координат!");
    }
}

// ------------------------------Конец определения методов--------------------------------------------