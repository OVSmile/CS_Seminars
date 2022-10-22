int A = GetUserNamber($"Введите число: ", "Ошибка ввода!");

int A2 = TransformNumber(A);

if (A > 0) Console.WriteLine(A2);
else Console.WriteLine($"1{A2}");

static int GetUserNamber(string massege, string errorMessage)
{
    Console.Write(massege);
    while (true)
    {
        bool isCorrect = int.TryParse(Console.ReadLine() ?? "", out int UserNumber);
        if (isCorrect)
            return UserNumber;
        Console.Write(errorMessage);
    }
}


int TransformNumber(int a)
{
    a = Math.Abs(a);
    int a2 = 0;
    int k = 1;

    while (a > 0)
    {
        a2 += a % 2 * k;
        a = a / 2;
        k *= 10;
    }
    return a2;
}
