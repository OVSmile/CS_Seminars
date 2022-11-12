// Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от 1 до N.
Console.Clear();

Console.Write("Введите N: ");
int N = int.Parse(Console.ReadLine() ?? "");
int Temp = 1;

Console.WriteLine(PrintDigits(N, Temp));

string PrintDigits(int n, int temp) // Метод вывода значений через тип string (так как в нём нет консольного вывода, он более универсальный)
{
    if (temp == n)
    {
        return temp.ToString();
    }
    return (temp + ", " + PrintDigits(n, temp + 1));  
}



// PrintDigits(N, temp); 

// void PrintDigits(int n, int temp)  // Метод вывода значений в консоль из метода
// {
//     if (temp == n) Console.WriteLine(n);
//     else 
//     {
//         Console.Write($"{temp}, ");
//         PrintDigits(n, temp + 1);
//     }
// }
