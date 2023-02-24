Console.Clear();

Console.Write("Введите элементы массива через пробел: ");
String elements = Console.ReadLine();

int[] array = GetArrayFromString(elements);

Console.Write("Задайте число для поиска в массиве: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine($"[{String.Join(",", array)}]");

if (FindElement(array, N))
{
    Console.WriteLine($"Число {N} ПРИСУТСТВУЕТ в массиве]");
}
else
{
    Console.WriteLine($"Число {N} ОТСУТСТВУЕТ в массиве]");
}

int[] GetArrayFromString(string stringArray)
{
    string[] numbers = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[numbers.Length];
    for (int i = 0; i < numbers.Length; i++)
    {
        result[i] = int.Parse(numbers[i]);
    }
    return result;
}

bool FindElement(int[] array, int element1)
{
    foreach (var item in array)
    {
        if (element1 == item)
        return true; 
    }
    return false;
}