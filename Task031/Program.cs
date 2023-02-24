Console.Clear();

int[] array = positiveNegativeArray(12, -9, 9);
Console.WriteLine(String.Join(", ", array));

// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine()!);
// int[] array = positiveNegativeArray(number);

int positiveSum = 0;
int negativeSum = 0;

// Console.WriteLine($"[{String.Join(", ", array)}]");

foreach (int e1 in array)
{
    positiveSum += e1 > 0 ? e1 : 0;
    negativeSum += e1 < 0 ? e1 : 0;
}

// for (int i = 0; i < array.Length; i++)
// {
//     int el = array[i];
//     if(el > 0)
//         positiveSum += el;
//     if(el < 0)
//         negativeSum += el;
// }

Console.WriteLine($"Positive Sum = {positiveSum}, Negative Sum = {negativeSum} ");

int[] positiveNegativeArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}

// int[] positiveNegativeArray (int size)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(-9, 9);
//     }
//     return result;
// }

//______________________________________________________________

// Решение последовательного заполнения:
/*int[] array1 = negativeArray(N);
int[] array2 = positiveArray(N);

Console.WriteLine($"[{String.Join(", ", array1)}, {String.Join(", ", array2)}]");

int[] negativeArray (int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(-9, 9);
    }
    return result;
}

int[] positiveArray (int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(9);
    }
    return result;
}
*/