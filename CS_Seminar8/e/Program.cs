int[,] pic = new int[,]
{
{1, 2, 3, 4 },
{12, 0, 0, 5 },
{11, 0, 0, 6 },
{10, 9, 8, 7 }
};
int contourNumber = 1;
int insideNamber = 13;


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


void FillConturNumbers(int row, int col, int temp)
{
    if ((pic[row, col] == 0 || row < 4) && (pic[row, col] == 0 || col < 4))
    {
        pic[row, col] = temp;
        FillConturNumbers(row, col + 1, temp + 1);
        FillConturNumbers(row + 1, col, temp + 1);
        FillConturNumbers(row, col - 1, temp + 1);
        FillConturNumbers(row - 1, col, temp + 1);
    }
}

// void FillInsideNumbers(int row, int col, int temp)
// {
//     if (pic[row, col] == 0)
//     {
//         pic[row, col] = temp;
//         FillInsideNumbers(row, col + 1, temp + 1);
//         FillInsideNumbers(row + 1, col, temp + 1);
//         FillInsideNumbers(row, col - 1, temp + 1);
//         FillInsideNumbers(row - 1, col, temp + 1);
//     }
// }

FillConturNumbers(0, 0, contourNumber);
//FillInsideNumbers(1, 1, insideNamber);
PrintArray(pic);
