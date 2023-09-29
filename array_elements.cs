int N = 100;
int[] array = new int[N];
Dictionary<int, int> seenElements = new Dictionary<int, int>();

Random random = new Random();
for (int i = 0; i < N; i++)
{
    array[i] = random.Next(1, 51);
}

Console.WriteLine("Содержимое массива: ");
foreach (var item in array)
{
    Console.Write($"{item} ");
}
Console.WriteLine("\n");

for (int i = 0; i < array.Length; i++)
{
    int currentElement = array[i];

    if (seenElements.ContainsKey(currentElement))
    {
        int indexOfFirstOccurrence = seenElements[currentElement];
        Console.WriteLine($"Найдено два одинаковых элемента: {currentElement}");
        Console.WriteLine($"Их индексы: {indexOfFirstOccurrence} и {i}");
        return; 
    }

    seenElements[currentElement] = i;
}

Console.WriteLine("Повторяющихся элементов не найдено.");
