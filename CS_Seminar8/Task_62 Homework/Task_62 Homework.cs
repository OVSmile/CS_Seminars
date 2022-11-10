Console.Clear();

Console.Write("Введите колличество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите колличество столбцов массива: ");
int collumns = int.Parse(Console.ReadLine() ?? "");


int[,] Array = new int[rows,collumns];

int contourNumber = 1;
int insideNamber = Array.GetLength(0) * 2 + Array.GetLength(1) * 2 - 3;


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

void FillConturNumbers(int[,] array, int temp)
{
    for (int i = 0; i < 1; i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = temp;
            temp++;
        }
    }
    for (int j = array.GetLength(1) - 1; j < array.GetLength(1); j++)
    {
        for (int i = 1; i < array.GetLength(0); i++)
        {
            array[i, j] = temp;
            temp++;
        }
    }
    for (int i = array.GetLength(0) - 1; i < array.GetLength(0); i++)
    {
        for (int j = array.GetLength(1) - 2; j >= 0; j--)
        {
            array[i, j] = temp;
            temp++;
        }
    }
    for (int j = 0; j < 1; j++)
    {
        for (int i = array.GetLength(0) - 2; i > 0; i--)
        {
            array[i, j] = temp;
            temp++;
        }
    }
}
void FillInsideNumbers(int row, int col, int temp)
{
    if (Array[row, col] == 0)
    {
        Array[row, col] = temp;
        FillInsideNumbers(row, col + 1, temp + 1);
        FillInsideNumbers(row + 1, col, temp + 1);
        FillInsideNumbers(row, col - 1, temp + 1);
        FillInsideNumbers(row - 1, col, temp + 1);
    }
}

FillConturNumbers(Array, contourNumber);
FillInsideNumbers(1, 1, insideNamber);
PrintArray(Array);