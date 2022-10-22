Console.WriteLine("Helo! Please enter three-digit number");
int number = int.Parse(Console.ReadLine() ?? "");

if (99 < number && number < 1000)
{
    Console.WriteLine($"{number} -> {number / 10 % 10}");
}
else
    Console.WriteLine("Won number");    


