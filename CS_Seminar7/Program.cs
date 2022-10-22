//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.


static int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine() ?? "", out int userNumber );
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

static int[,] GetArray(int row, int column, int minRandomValue, int maxRansomValue)
{
    int[,] randomArray = new int[row, column];

    for (int rowIndex = 0; rowIndex < row; rowIndex++)
    {
        for (int columnIndex = 0; columnIndex < column; columnIndex++)
        {
            randomArray[rowIndex, columnIndex] = new Random().Next(minRandomValue, maxRansomValue + 1);
        }
    }
    return randomArray;
}

static void PrintArray(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            Console.Write($"{array[row, column]} ");
        }
        Console.WriteLine();
    }
}

static void GetNewArray(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row +=2)
    {
        for (int column = 0; column < array.GetLength(1); column +=2)
        {
            array[row, column] *= array[row, column];
        }
    }
}

Console.Clear();

int row, column;

while (true)
{
    row = GetNumberFromUser("Enter number of rows are in your array : ", "Error. Try again.");
    if (row > 0)
        break;
    else Console.WriteLine("Error. Array length must have positive value.");
}

while (true)
{
    column = GetNumberFromUser("EEnter number of columns are in your array : ", "Error. Try again.");
    if (column > 0)
        break;
    else Console.WriteLine("Error. Array length must have positive value.");
}

int min = GetNumberFromUser("Enter minimum value for your array : ", "Error. Try again.");
int max = GetNumberFromUser("Enter maximum value for your array ", "Error. Try again.");

Console.Clear();

int[,] array = GetArray(row, column, min, max);
PrintArray(array);
Console.WriteLine();
GetNewArray(array);
PrintArray(array);

PrintArray(array);
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

Console.Write("Введите колличество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите колличество столбцов массива: ");
int coluns = int.Parse(Console.ReadLine() ?? "");
/////////////////////////////////////////////////////////////
int[,] array = GetArray(rows, coluns, 0, 10);
PrintArray(array);
Console.WriteLine();
int sum = SumArray(array);
Console.Write(sum);

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
От Валерий всем 09:47 PM
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

int SumArray(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i == j)
                sum += array[i,j];
        }
    }
    return sum;
}
