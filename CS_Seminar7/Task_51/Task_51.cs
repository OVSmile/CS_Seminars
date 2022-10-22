// Задайте двумерный массив размером m x n, Найдите сумму элементов,
// находящихся на главной диагонали с индексами (0,0); (1,1); и т.д.

Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");

int[,] array = GetArray(rows, columns, 0, 10);

int SizeArrayDiagonalElements = 0;
if(rows < columns) SizeArrayDiagonalElements = rows - 1;
else SizeArrayDiagonalElements = columns - 1;

int[] ArrayDiagonalElements = GetArrayDiagonalElements(array, SizeArrayDiagonalElements);
int SumOfDiagonalElements = GetSumArrayDiagonalElements(ArrayDiagonalElements);

PrintArray(array);
Console.WriteLine($"Сумма элементов главной диагонали: {String.Join("+", ArrayDiagonalElements)} = {SumOfDiagonalElements}");


// Методы 

int[,] GetArray(int m, int n, int minValue, int maxValue)
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

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[] GetArrayDiagonalElements(int[,] arr, int size)
{
    int[] result = new int[size + 1];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if(i == j) result[j] = arr[i, j];
        }
    }
    return result;
}

int GetSumArrayDiagonalElements(int [] ArrayDiagonal)
{
    int sum = 0;
    foreach(int el in ArrayDiagonal) sum += el; 
    return sum;   
}