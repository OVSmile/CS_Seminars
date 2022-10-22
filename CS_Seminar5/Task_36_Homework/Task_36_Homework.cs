// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов стоящих на нечётных позициях.

int Size = GetUserNumber("Введите размер массива: ", "Ошибка ввода!");
int MinValue = GetUserNumber("Введите минимальное число массива: ", "Ошибка ввода!");
int MaxValue = GetUserNumber("Введите максимальное число массива: ", "Ошибка ввода!");
int[] Array = FillArray(Size, MinValue, MaxValue);
int OddSum = GetOddSum(Array);
Console.WriteLine($"[{String.Join(",", Array)}] -> {OddSum}");

// ----------------------------------------------------------------------------------

// Проверка ввода данных пользователя.
int GetUserNumber(string message, string errorMessage)
{
    Console.Write(message);
    while(true)
    {
        bool isCorrect = int.TryParse(Console.ReadLine() ?? "", out int UserNumber);
        if (isCorrect)
            return UserNumber;
        Console.WriteLine(errorMessage);
    }
}

// Заполнение массиа случайными числами.
int[] FillArray(int size, int minValue, int maxValue)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}

// Вычисление суммы элементов с нечетными индексами.
int GetOddSum(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}
