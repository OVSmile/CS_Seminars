int A = GetUserNamber($"Введите число: ", "Ошибка ввода!");
int B = GetUserNamber($"Введите число: ", "Ошибка ввода!");
int C = GetUserNamber($"Введите число: ", "Ошибка ввода!");

bool res = TriangleCheck(A, B, C);
if (res) Console.Write("Да, треуголник существует");
else Console.Write("Нет, такого треугольника не существует");

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

bool TriangleCheck(int a, int b, int c)
{
    if (a > b + c || b > a + c || c > a + b) return false;
    return true;
}