// Задайте массивю Напишите программу, котрая определяет,
// присутствует ли заданное число в массиве. 

Console.Clear();


int size = GetUserNamber($"Введите размер массива: ", "Ошибка ввода!");
int minValue = GetUserNamber($"Введите минимальное значение массива: ", "Ошибка ввода!");
int maxValue = GetUserNamber($"Введите максимальное значение массива: ", "Ошибка ввода!");
int userNumber = GetUserNamber($"Введите число: ", "Ошибка ввода!");
int[] Array = new int[size];
GetArray(Array);
Console.Write($"{userNumber}; массив [{String.Join(",", Array)}] -> ");

bool res = FindUserNumber(Array, userNumber);
if (res) Console.Write("Да");
else Console.Write("Нет");

//---------------------------------------------------------------------------------

// Заполнение массива случайными числами.
void GetArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
}

// Проверка ввода данных пользователем.
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

// Поиск числа в массиве.
bool FindUserNumber(int[] array, int num)
{
    foreach (int el in array)
    {
        if (el == num) return true;
    }
    return false;
}