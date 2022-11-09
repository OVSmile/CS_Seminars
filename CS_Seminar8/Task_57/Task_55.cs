// Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных
Console.Clear();
int row = new Random().Next(1, 10);
int column = new Random().Next(1, 10);
// int row = 4;
// int column = 4;
int minRandomValue = new Random().Next(-9, 0);
int maxRansomValue = new Random().Next(0, 10);
int[,] array = GetArray(row, column, minRandomValue, maxRansomValue);

PrintArray(array);

Console.WriteLine();

GetCheckArray(array);


static int[,] GetArray(int row, int column, int minRandomValue, int maxRansomValue)
{
    int[,] randomArray = new int[row, column];

    for (int rowIndex = 0; rowIndex < row; rowIndex++)
    {
        for (int columnIndex = 0; columnIndex < column; columnIndex++)
        {
            randomArray[rowIndex, columnIndex] = new Random().Next(minRandomValue, maxRansomValue);
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

static void GetCheckArray(int[,] array)
{
    int count = 0;
    int[] list = new int[array.GetLength(0) * array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            foreach (int el in array)
            {
                if (el == array[i, j])
                {
                    count ++;
                }
            }
            Console.WriteLine($"{array[i, j]} встречается {count} раз");
            count = 0;
        }
    }
}