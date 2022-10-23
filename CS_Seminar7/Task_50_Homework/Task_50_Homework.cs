// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.Clear();



int rows = new Random().Next(0, 10);
int columns = new Random().Next(0, 10);

int[,] Array = FillArray(rows, columns, 0, 10);
PrintArray(Array);

Console.Write("Введите номер строки искомого элемента: ");
int UserRow = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите номер столбца искомого элемента: ");
int UserColomn = int.Parse(Console.ReadLine() ?? "");

if (rows < UserRow || columns < UserColomn) 
    Console.WriteLine($"В массиве нет числа распложенного на {UserRow}-ой строке, {UserColomn}-го столбца");
else
    Console.WriteLine($"Значение числа распложенного на {UserRow}-ой строке, {UserColomn}-го столбца, равно {Array[UserRow - 1, UserColomn - 1]}");

//--------------------------------------------------------------------------------------------------------------


int[,] FillArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}