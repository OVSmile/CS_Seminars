// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B. 

Console.Clear();
int A = GetUserNumber("Введите число А: ", "Ошибка ввода!");
int B = GetUserNumber("Введите число B: ", "Ошибка ввода!");
int power = GetNumberAToPowerOfB(A, B);
Console.WriteLine($"{A}, {B} -> {power}");

// Проверка ввода данных пользователя.
int GetUserNumber(string message, string errorMessage)
{
    while (true)
    {
    Console.Write(message);
    bool isCorrect = int.TryParse(Console.ReadLine(), out int UserNumber);
    if (isCorrect)
        return UserNumber;
    Console.WriteLine(errorMessage); 
    }
}

// Возыедение числа A в натуральную степень B. 
int GetNumberAToPowerOfB(int a, int b)
{
    int result = (int)(Math.Pow(a, b));
    return result;
}
