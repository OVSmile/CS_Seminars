// Напишите программу, которая по заднному номеру четверти показывает 
// диапазон возможных координат точек в этой четверти (х и у)

// ------------------------------Начало программы------------------------------------------------
Console.Clear();
int Quarter = 0;

InitCoordinatesByUser(ref Quarter);     // Вызов методов с передачей параметровв по ссылке (ref)
PrintQuarterByCoords(Quarter);          // Вызов методов с передачей параметровв по значению
// ------------------------------Конец программы------------------------------------------------

// ------------------------------Определение методов--------------------------------------------

// ---------------------------------------------------------------------------------------------
// Определяем функцию, выполняющую ввод номера четверти
static void InitCoordinatesByUser(ref int quarter)
{
    try
    {
        Console.Write("Введите номер четверти: ");
        quarter = int.Parse(Console.ReadLine() ?? "");
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        return;
    }
}

// ---------------------------------------------------------------------------------------------
// Определяем функцию, принимающую значение номера четверти
// и выводящую в консоль диапазон возможных координат точек в этой четверти (х и у)
static void PrintQuarterByCoords(int quarter)
{
    if (quarter == 1)
    {
        Console.WriteLine("x > 0, y > 0");
    }
    else if (quarter == 2)
    {
        Console.WriteLine("x > 0, y < 0");
    }
    else if (quarter == 3)
    {
        Console.WriteLine("x < 0, y < 0");
    }
    else if (quarter == 4)
    {
        Console.WriteLine("x > 0, y < 0");
    }
    else
    {
        Console.WriteLine("Ошибка! Ведите коректный номер четверти!");
    }
}

// ------------------------------Конец определения методов--------------------------------------------
