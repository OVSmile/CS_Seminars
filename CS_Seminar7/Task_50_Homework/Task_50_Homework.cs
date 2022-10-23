// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.Clear();



int rows = new Random().Next(5, 10);
int colimns = new Random().Next(5, 10);

int[,] Array = FillArray(rows, colimns, 0, 100);
PrintArray(Array);

Console.Write("Введите номер строки искомого элемента: ");
int UserRow = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите номер столбца искомого элемента: ");
int UserColomn = int.Parse(Console.ReadLine() ?? "");

int UserNumber = (GetUserValue(Array, UserRow, UserColomn));

if(UserNumber >= 0) Console.WriteLine($"Значение числа распложеннго на {rows} строке и {colimns} столбце равно {UserNumber}");
else Console.WriteLine($"В массиве нет числа распложеннго на {rows} строке и {colimns} столбце");

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

int GetUserValue(int[,] array, int row, int colimn)
{
    int value;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i == row && j == colimn)
            {
               value = array[i, j]; 
               return value;
            } 
        }
    }
    return -101;
}
