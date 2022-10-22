Console.WriteLine("Helo! Please enter number");
int number = int.Parse(Console.ReadLine() ?? "");

if (number / 100 == 0)
{
    Console.WriteLine($"{number} -> Еhere is no third digit");
}
else
    Console.WriteLine($"{number} -> {number / 100 % 10}");    