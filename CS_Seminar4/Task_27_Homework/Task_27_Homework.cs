// Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.

Console.Clear();
int UserNumber = GetUserNumber("Введите число: ", "Ошибка ввода!");
int sum = GetSumDigitOfNumber(UserNumber);
Console.WriteLine($"{UserNumber} -> {sum}");

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

// Возвращает сумму цифр числа
int GetSumDigitOfNumber(int num)
{
    sum = 0;
    for (int i = num; i != 0; i /= 10)
    {
        sum += i % 10;
    }
    return sum;
}