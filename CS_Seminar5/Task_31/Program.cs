int[] array = GetArray(12, -9, 9);

PrintArray(array);

int negativeSum = GetNegativeSum(array);
Console.WriteLine($"\nСумма отрицаткльных чисел массива равна {negativeSum}");

int PositiveSum = GetPositiveSum(array);
Console.WriteLine($"Сумма положительных чисел массива равна {PositiveSum}");

///////////////////////////////////////////////////////////////////////////
// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// }
void PrintArray(int[] array)
{
    foreach (int el in array)
    {
        Console.Write(el + " ");
    }
}

int GetNegativeSum(int[] array)
{
    int negativeSum = 0;
    foreach(int el in array)
    {
        if(el<0) negativeSum += el;
    } 
    return negativeSum;
}

int GetPositiveSum(int[] array)
{
    int PositiveSum = 0;
    foreach(int el in array)
    {
        if(el>0) PositiveSum += el;
    } 
    return PositiveSum;
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int [size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}