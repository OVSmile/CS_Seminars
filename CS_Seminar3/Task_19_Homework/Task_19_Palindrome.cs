Console.Clear();

int number = 0;

InitNumberByUser(ref number);
Palindrome(number);

static void InitNumberByUser(ref int num)
{
    try
    {
        Console.Write("Введите пятизначное число: ");
        num = int.Parse(Console.ReadLine() ?? "");
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        return;
    }
}

static void Palindrome(int num)
{
    if (num > 9999 && num < 100000)
    {
        if (num / 10000 == num % 10)
        {
            int num1 = num % 10000 / 10;

            if (num1 / 100 == num1 % 10)
            {
                Console.WriteLine($"{num} -> Да");
            }
            else
                Console.WriteLine($"{num} -> Нет");
        }
    }
    else
        Console.WriteLine($"{num} -> Введено неккорректное число");
}