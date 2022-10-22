Console.WriteLine("Hello, enter the number.");
int number = int.Parse(Console.ReadLine() ?? "");

int count = 2;

Console.Write(number + " ->");

while (count <= number)
{
    if (count == number) Console.Write(" " + count);
    else if (count + 1  == number) Console.Write(" " + count);
    else Console.Write(" " + count + ",");
    
    count += 2;
}