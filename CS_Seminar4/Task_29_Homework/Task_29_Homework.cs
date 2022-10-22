// Напишите программу, которая задёт массив из 8 элементов 
// и выводит их на экран.

Console.Clear();
int[] array = new int[8];
FillArray(array);
Console.Write($"{String.Join(",", array)} -> [{String.Join(",", array)}]");

// Заполнение массива данными пользователя
void FillArray(int[] collection)
{
    int length = collection.Length;
    for (int i = 0; i < length; i++)
    {
        int num = GetUserNumber($"Введите {i + 1}-е число массива: ", "Ошибка ввода!");
        collection[i] = num;
    }
}

 // Проверка ввода данных пользователя
int GetUserNumber(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int UsNumber);
        if (isCorrect)
            return UsNumber;
        Console.WriteLine(errorMessage);
    }
}