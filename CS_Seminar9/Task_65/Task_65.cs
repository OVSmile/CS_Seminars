// Задайте значения M и N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от M до N.

Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите M: ");
int M = int.Parse(Console.ReadLine() ?? "");



Console.WriteLine(PrintDigits(N, M));

string PrintDigits(int n, int m) // Метод вывода значений через тип string (так как в нём нет консольного вывода, он более универсальный)
{
    if (m < n)
    {
        if (m == n)
        {
            return m.ToString();
        }
        return (m + ", " + PrintDigits(n, m + 1));
    }

    else
    {
        if (m == n)
        {
            return m.ToString();
        }
        return (m + ", " + PrintDigits(n, m - 1));
    }
}