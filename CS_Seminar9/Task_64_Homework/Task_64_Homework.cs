// Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
Console.Clear();

Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine($"N = {N} -> \"{PrintDigits(N)}\"");

string PrintDigits(int n) // Метод вывода значений через тип string (так как в нём нет консольного вывода, он более универсальный)
{
    if (n == 1)
    {
        return n.ToString();
    }
    return (n + ", " + PrintDigits(n - 1));  
}
