// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");

int[,] Array = GetArray(rows, columns, 0, 10); 
PrintArray(Array);
double[] ArithmeticMeanColumns = GetArithmeticMeanColumns(Array, rows, columns);

Console.Write($"Среднее арифметическое значение элементов каждого столбца: {String.Join("; ", ArithmeticMeanColumns)}.");

//---------------------------------------------------------------------------

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

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

double[] GetArithmeticMeanColumns(int[,] array, int rows, int columns)
{
    double[]  ArithmeticMeanColumns = new double[columns];
    double sum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
        }
        ArithmeticMeanColumns[i] = Math.Round(sum / rows, 1);
        sum = 0;
    }
    return ArithmeticMeanColumns;
}