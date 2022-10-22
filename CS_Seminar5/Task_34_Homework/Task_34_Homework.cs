// Задайте массив заполненный случайными трехначными числами,
// Напишите программу, которая покажет колличество четных чисел в массиве.

int[] Array = FillArray(4, 100, 1000);
int EvenNumbers = GetEvenNumbers(Array);
Console.Write($"{String.Join(",", Array)} -> {EvenNumbers}");

//-------------------------------------------------------------------------

// Заполнение массива.
int[] FillArray(int size, int minValue, int maxValue)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}

// Определение колличества четных чисел в массиве.
int GetEvenNumbers(int[] array)
{
    int count = 0;
    foreach(int el in array)
    {
        if (el % 2 == 0)
            count += 1;
    }
    return count;
}
