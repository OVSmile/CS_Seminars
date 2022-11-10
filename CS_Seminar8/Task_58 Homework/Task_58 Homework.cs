// Задайте две матрицы. Напишите программу, 
//которая будет находить произведение двух матриц.
Console.Clear();

Console.Write("Введите количество строк 1 массива: ");
int rowsFirst = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов 1 массива: ");
int columnsFirst = int.Parse(Console.ReadLine() ?? "");
int[,] arrayFirst = GetArray(rowsFirst, columnsFirst, 0, 10);

Console.Write("Введите количество строк 2 массива: ");
int rowsSecond = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов 2 массива: ");
int columnsSecond = int.Parse(Console.ReadLine() ?? "");
int[,] arraySecond = GetArray(rowsSecond, columnsSecond, 0, 10);

Console.WriteLine("Первый массив");
PrintArray(arrayFirst);
Console.WriteLine();
Console.WriteLine("Второй массив");
PrintArray(arraySecond);
Console.WriteLine();
Console.WriteLine("Произведение массивов");
int[,] arrayThird = GetMatrixЬultiplication(arrayFirst, arraySecond);
PrintArray(arrayThird);


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

int[,] GetMatrixЬultiplication(int[,] array1, int[,] array2)
{
    int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];
    int sum = 0;
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                 sum += array1[i, k] * array2[k, j];
            }
            result[i, j] += sum;
            sum = 0;   
        }
    } 
    return result;
}

