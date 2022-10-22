Console.Clear();

int X1, Y1, Z1, X2, Y2, Z2;
X1 = Koords("Введите координату Х1: "); 
Y1 = Koords("Введите координату Y1: ");
Z1 = Koords("Введите координату Z1: ");
X2 = Koords("Введите координату Х2: ");
Y2 = Koords("Введите координату Y2: ");
Z2 = Koords("Введите координату Z2: ");

Console.WriteLine($"Расстояние, между точкой А({X1}, {Y1}. {Z1}) и точкой В({X2}, {Y2}, {Z2}), равно {PrintDistanceBetweenPoints(X1, Y1, Z1, X2, Y2, Z2)}");

static int Koords(string massedg)
{
    try
    {
        Console.Write(massedg);
        int result = int.Parse(Console.ReadLine() ?? "");
        return result;
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        return -1;
    }
}   


static double PrintDistanceBetweenPoints(int x1, int y1, int z1, int x2, int y2,  int z2)
{
    double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
    return result;
}



