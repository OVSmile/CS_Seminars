// Напишите программу замены элементов массива:
// положительные элементы заменить на отрицательные, и наоборот. 

Console.Clear();

int size = GetUserNamber($"Введите размер массива: ", "Ошибка ввода!");
int[] Array = new int[size];
GetArray(Array);
Console.Write($"[{String.Join(",", Array)}] -> ");
ArrayElementSwap(Array);
Console.Write($"[{String.Join(",", Array)}]");
//---------------------------------------------------------------------------------

// Заполнение массива числами вводимыми пользователем
void GetArray(int[] arr)
{
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i + 1}-ое число массива: ");
        arr[i] = GetUserNamber($"Введите {i + 1}-ое число массива: ", "Ошибка ввода!");
    }
}

// Проверка ввода данных пользователем
int GetUserNamber(string massege, string errorMessage)
{
    Console.Write(massege);
    while (true)
    {
        bool isCorrect = int.TryParse(Console.ReadLine() ?? "", out int UserNumber);
        if (isCorrect)
            return UserNumber;
        Console.Write(errorMessage);
    }
}

// Замена элементов массива
void ArrayElementSwap(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * -1;
    }
}