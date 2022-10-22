Console.WriteLine("Hello, enter the first number.");
int number1 = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Hello, enter the second number.");
int number2 = int.Parse(Console.ReadLine() ?? "");

if (number1 > number2)
{
    Console.WriteLine("a = " + number1 + "; b = " + number2 + "-> max = " + number1);
}
else
    Console.WriteLine("a = " + number1 + "; b = " + number2 + " -> max = " + number2);
