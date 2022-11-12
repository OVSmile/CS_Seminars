// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Write("Введите M: ");
int M = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine() ?? "");
int sum = 0;



Console.WriteLine(PrintDigits(M, N, sum));

int PrintDigits(int m, int n, int result)
{
    if (m < n)
    {
        if (m == n)
        {
            return result;
        }
        return (result += m + PrintDigits(m + 1, n, result));
    }

    else
    {
        if (m == n)
        {
            return result += n;
        }
        return (result += m + PrintDigits(m - 1, n, result));
    }
}
