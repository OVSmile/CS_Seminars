Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine() ?? "");

Console.Write($"{N} -> ");
PrintSquares(N);


static void PrintSquares(int N)
{
    for(int i = 1; i < N; i++)
    {
        Console.Write($"{i*i}, ");
    }
    Console.Write($"{N*N}");
}
