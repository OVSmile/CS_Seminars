// Напишите программу, которая на вход принимает два числа A и B,
// и возводит число А в целую степень B с помощью рекурсии.

Console.Write("Введите A: ");
int A = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите B: ");
int B = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine($"A = {A}; B = {B} -> {PowerRec(A, B)}");

int PowerRec(int a, int n)
{
    if (n == 0) return 1;
    else if (n % 2 == 0) return PowerRec(a * a, n / 2);
    else return PowerRec(a, n - 1) * a;
}
