Console.WriteLine("Hello, enter the number.");
int number = int.Parse(Console.ReadLine() ?? "");

if (number % 2 == 1)
{
    Console.WriteLine(number  + " -> нет, числло не чётное");
}
else
    Console.WriteLine(number  + " -> да, числло чётное");

