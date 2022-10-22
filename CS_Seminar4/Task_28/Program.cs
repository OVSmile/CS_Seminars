// Задача 28. Напишите программу, которая принимает
// на вход число N и выдаёт произведение чисел от 1 до N.
Console.Clear();

int num = GetNumberFromUser("Введите число A: ", "Ошибка ввода!");
int FactorialNumbers = GetFactorialNumbers(num);
Console.WriteLine($"{num} -> произведение цифр числа {FactorialNumbers}");
// Выводит в консоль сообщение message,
// преобразовывает введённую пользователем строку в число типа int.
// В случае ошибки выводит в консоль сообщение errorMessage

int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

// Возвращает колличество цифр в числе number
int GetFactorialNumbers(int number)
{
    int count = 1;
    while (number != 0)
    {
        if (number > 0)
        {
            count = count * number;
            number = number - 1;
        }
        else if (number < 0)
        {
            count = count * number;
            number = number + 1;
        }
    }
    return count;
}
