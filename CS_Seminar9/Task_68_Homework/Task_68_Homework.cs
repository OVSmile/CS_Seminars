// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

Console.Write("Введите M: ");
uint M = uint.Parse(Console.ReadLine() ?? "");
Console.Write("Введите N: ");
uint N = uint.Parse(Console.ReadLine() ?? "");

Console.WriteLine($"m = {M}, n = {N} -> \"{AckermanFunction(M, N)}\"");

uint AckermanFunction(uint m, uint n) //функция Аккермана
{
  if (m == 0)
    return n + 1;
  else
    if ((m != 0) && (n == 0))
      return AckermanFunction(m - 1, 1);
    else
      return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
}