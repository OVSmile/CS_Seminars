// Задача 26. Напишите программу, которая принимает
// на вход число и выдаёт количестыо цифр в числе.
Console.Clear();
int num = GetNumberFromUser("Введите целое число A: ", "Ошибка ввода!");
int sumNumbers = GetNumbrOfDigits(num);
Console.WriteLine($"{num} -> количество цифр в числе {sumNumbers}");
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
int GetNumbrOfDigits(int number)
{
    int count = 0;
    while (number != 0)
    {
            number = number / 10;
            count += 1;
    }
    return count;
}