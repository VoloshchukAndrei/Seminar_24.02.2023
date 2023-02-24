Console.Clear();

int[] startArray = RangeArray(123, 1, 150);

Console.WriteLine($"[{String.Join(",", startArray)}]");

Console.WriteLine($"Количество элементов в отрезке от 10 до 99 = {GetCountElements(startArray, 10, 99)}");

int[] RangeArray (int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}


int GetCountElements(int[] array, int leftRange, int rigthRange)
{
    int count = 0;
    foreach (var item in array)
    {
        if(item >= leftRange && item <= rigthRange) count++;
    }
    return count;
}


//_________________________________________________________

// Console.Clear();

// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine()!);

// int[] array = RangeArray(number);

// int count = 0;

// for (int i = 0; i < number; i++)
// {
//     if (array[i] >= 10 && array[i] <= 99)
//     {
//         count++;
//     }
// }

// Console.WriteLine($"[{String.Join(",", array)}] -> {count}");

// int[] RangeArray (int size)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(1, 150);
//     }
//     return result;
// }
