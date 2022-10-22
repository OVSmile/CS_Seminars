Console.Clear();

// Пользователь вводит с клавиатуры М чисел. 
// Посчитайте, сколько чисел больше нуля ввёл пользователь.
Console.WriteLine("Введите необходимое колличество чисел, для завершения ввода введите 'Q'.");
int[] UserArray = FillArray();
Console.WriteLine($"{String.Join(",", UserArray)} -> колличество введённых чисел больше 0 равно: {PositiveNumbers(UserArray)}");
//-------------------------------------------------------------------------------------------------------------------------------

// Метод проверки ввода данных пользователем
int GetUserNamber(string massege, string errorMessage)
{
    while (true)
    {
        bool isCorrect = int.TryParse(massege, out int UserNumber);
        if (isCorrect)
            return UserNumber;
        Console.WriteLine(errorMessage);
        Console.WriteLine("Повторите ввод числа: ");
        massege = Console.ReadLine() ?? "";
    }
}

// Метод заполнения массива (с помощью списков), при неизвестной заранее длине массива
int[] FillArray()
{
    string UserMassege = "";
    int[] arr = new int[1];
    List<int> UserNumbers = new List<int>();

    while (UserMassege != "Q")
    {
        for (int i = 0; i < 100; i++)
        {
            Console.Write($"Введите {i + 1}-ое число: ");
            UserMassege = Console.ReadLine() ?? "";

            if (UserMassege == "Q")
            {
                Console.WriteLine("Ввод данных завершен.");
                arr = UserNumbers.ToArray();
                return arr;
            }
            UserNumbers.Add(GetUserNamber(UserMassege, "Ошибка ввода!")); 
        }
    }
    arr = UserNumbers.ToArray();
    return arr;
}

// Метод подсчета колличесва элементов больше 0 в массиве
int PositiveNumbers(int[] array)
{
    int count = 0;
    foreach (int el in array)
        if (el > 0) count ++;
    return count; 
}