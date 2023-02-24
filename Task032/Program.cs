Console.Clear();

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

int[] array = RandomArray(number);

Console.WriteLine($"[{String.Join(", ", array)}]");

for (int i = 0; i < number; i++)
{
    array[i] = array[i] * -1;
}

Console.WriteLine($"[{String.Join(", ", array)}]");

int[] RandomArray (int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(-100, 100);
    }
    return result;
}

// Console.Clear();
// int[] startArray = GetArray(6, -10, 10);
// Console.WriteLine(String.Join(" ", startArray));
// Console.WriteLine(String.Join(" ", InversArray(startArray)));

// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] res = new int[size];

//     for (int i = 0; i < size; i++)
//     {
//         res[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return res;
// }

// int[] InversArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] *= -1;
//     }
//     return array;
// }