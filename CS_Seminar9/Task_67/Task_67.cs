// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine() ?? "");
int sum = 0;

Console.WriteLine(PrintDigits(N, sum));

int PrintDigits(int n, int result) // Метод вывода значений через тип string (так как в нём нет консольного вывода, он более универсальный)
{
        if (n == 0)
        {
            return result;
        }

        return result += n % 10 + PrintDigits(n / 10, result);
        
}