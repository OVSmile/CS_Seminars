Console.Clear();

// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Введите значения 1-ой переменной (k1) и 2-ой переменной (b1) для уравнения, которым задана первая прямая: ");
double k1 = GetUserNumber("Значение 1-ой переменной: ", "Ошибка ввода!");
double b1 = GetUserNumber("Значение 2-ой переменной: ", "Ошибка ввода!");

Console.WriteLine("Введите значения 1-ой переменной (k2) и 2-ой переменной (b2) для уравнения, которым задана вторая прямая: ");
double k2 = GetUserNumber("Значение 1-ой переменной: ", "Ошибка ввода!");
double b2 = GetUserNumber("Значение 2-ой переменной: ", "Ошибка ввода!");

double x = GetCoordinateX(k1, b1, k2, b2);
double y = GetCoordinateY(x, k1, b1);

Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> точка пересечения данных прямых ({x}; {y})");

//------------------------------------------------------------------------------------------------------------------

// Метод проверки ввода данных пользователем.
double GetUserNumber(string message, string errorMessage)
{
    Console.Write(message);
    while(true)
    {
        bool isCorrect = double.TryParse(Console.ReadLine() ?? "", out double UserNumber);
        if (isCorrect)
            return UserNumber;
        Console.WriteLine(errorMessage);
    }
}

// Метод получения значения координаты X.
double GetCoordinateX(double K1, double B1, double K2, double B2)
{
    double CoordinateX = (B1 - B2) / (K2 - K1);

    return CoordinateX; 
}

// Метод получения значения координаты Y.
double GetCoordinateY(double X, double K1, double B2)
{
    double CoordinateY = K1 * X + B2;

    return CoordinateY; 
}
