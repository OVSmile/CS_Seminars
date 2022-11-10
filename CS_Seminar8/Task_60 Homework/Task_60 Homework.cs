// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
Console.Clear();

Console.Write("Введите колличество строк массива: ");
int row = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите колличество столбцов массива: ");
int col = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите колличество строк в глубину массива: ");
int dep = int.Parse(Console.ReadLine() ?? "");
Console.WriteLine();


if ((row * col * dep) > 100)
    Console.WriteLine("Ошибка! Количество элементов в матрице не может превышать 100");
else
{
    int[,,] array = CreateArray(row, col, dep, 1, 100);
    PrintArray(array);
}


int[,,] CreateArray(int row, int col, int dep, int min, int max)
{
    int[,,] matrix = new int[row, col, dep];
    Random rnd = new Random();
    int t = 0;
    //matrix[0,0,0] = t;
    List<int> temp = new List<int>() { t };

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                while (true)
                {
                    t = rnd.Next(min, max + 1);
                    if (temp.Contains(t))
                        continue;
                    else
                    {
                        temp.Add(t);
                        matrix[i, j, k] = t;
                        break;
                    }
                }

            }
        }
    }
    Console.WriteLine(String.Join(",", temp));
    return matrix;
}

void PrintArray(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]}({i}, {j}, {k}) ");
            }
        }
        Console.WriteLine();
    }
}
