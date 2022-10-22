// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементами массива.
Console.Clear();
int Size = GetUserNumber("Введите размер массива: ", "Ошибка ввода!");
double[] Array = FillArray(Size);
double DiffBetweenMaxMin = GetMax(Array) - GetMin(Array);
Console.WriteLine($"[{String.Join(", ", Array)}] -> {DiffBetweenMaxMin}");

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
double[] FillArray(int size)
{
    double[] arr = new double[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = Math.Round(new Random().NextDouble() * 10, 2);
    }
    return arr;
}

// Вычисление максимального элемента массива.
double GetMax(double[] array)
{
    double max = array[0];
    foreach(double el in array)
    {
        if(el > max)
            max = el;
    }
    return max;
}

// Вычисление минимального элемента массива.
double GetMin(double[] array)
{
    double min = array[0];
    foreach(double el in array)
    {
        if(el < min)
            min = el;
    }
    return min;
}
