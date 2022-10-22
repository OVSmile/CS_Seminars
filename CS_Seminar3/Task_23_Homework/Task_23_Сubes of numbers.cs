Console.Clear();

int N = 0;

InitNumberByUser(ref N);
PrintСubes(N);

static void InitNumberByUser(ref int n)
{
    try
    {
        Console.Write("Введите число N: ");
        n = int.Parse(Console.ReadLine() ?? "");
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        return;
    }
}

static void PrintСubes(int N)
{
    Console.Write($"{N} -> ");

    for(int i = 1; i < N; i++)
    {
        Console.Write($"{Math.Pow(i, 3)}, ");
    }
    Console.Write($"{Math.Pow(N, 3)}");
}

