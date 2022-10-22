Console.WriteLine("Hello, enter the first number.");
int number1 = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Hello, enter the second number.");
int number2 = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Hello, enter the third number.");
int number3 = int.Parse(Console.ReadLine() ?? "");

int max = number1;

if (number2 > max)
{
    max = number2;
}
if (number3 > max)
{
    max = number3;
}

Console.WriteLine(number1 + ", " + number2 + ", " + number3 + " -> max = " + max); 