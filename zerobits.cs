//Глубоко извиняюсь, если я неправильно понял данное задание.
//Честно говоря, впервые услышал про нулевые биты и все что получилось узнать и накопать, это нули в бинарном коде.
//Поэтому перевел это все в бинарный код и далее уже работал с этим.
//Быстрый способ работает в 3-5 раз быстрее простого варианта, ибо используется немного другое написание.

using System.Diagnostics;
Stopwatch stopwatch = new Stopwatch();
while (true)
{
    Console.WriteLine("\nВведите строку:");
    string input = Console.ReadLine();
    Console.Clear();
    #region Стандартный простой способ
    stopwatch.Start();
    string binaryCode = StringToBinary(input);

    if (binaryCode.Length > 0)
    {
        binaryCode = binaryCode.Substring(0, binaryCode.Length - 1);
    }

    int countZeroBits = CountZeroBits(binaryCode);

    Console.WriteLine("Количество нулевых битов простой способ: " + countZeroBits);
    stopwatch.Stop();
    Console.WriteLine($"Затраченное время в тиках: {stopwatch.ElapsedTicks}");
    stopwatch.Reset();
    #endregion
    #region Быстрый способ
    stopwatch.Start();
    string binaryCodeFast = StringToBinaryFast(input);
    if (binaryCodeFast.Length > 0)
    {
        binaryCodeFast = binaryCodeFast.Substring(0, binaryCodeFast.Length - 1);
    }
    int countZeroBitsFast = CountZeroBitsFast(binaryCodeFast);

    Console.WriteLine("Количество нулевых битов быстрый способ: " + countZeroBitsFast);
    stopwatch.Stop();
    Console.WriteLine($"Затраченное время в тиках: {stopwatch.ElapsedTicks}");
    #endregion
}

string StringToBinary(string input)
{
    string binary = "";

    foreach (char c in input)
    {
        binary += Convert.ToString(c, 2);
    }

    return binary;
}

int CountZeroBits(string binary)
{
    int count = binary.Count(bit => bit == '0');
    return count;
}

int CountZeroBitsFast(string binary)
{
    int count = 0;

    for (int i = 0; i < binary.Length; i++)
    {
        if (binary[i] == '0')
        {
            count++;
        }
    }
    return count;
}

string StringToBinaryFast(string input)
{
    string binary = "";

    for (int i = 0; i < input.Length; i++)
    {
        binary += Convert.ToString(input[i], 2);
    }


    return binary;
}
