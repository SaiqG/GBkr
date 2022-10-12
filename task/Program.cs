using System.Globalization;
Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");

string[] EnterAndSplitString()
{
    Console.Write("Ведите слова через пробел, запятую или / : ");
    return Console.ReadLine()!.Split(' ', ',', '/');
}

string[] SortStrings(string[] initString)
{
    string[] lessThen3digit = new string[initString.Length];
    int i = 0;
    foreach (string item in initString)
    {
        if (item.Length < 4)
        {
            lessThen3digit[i++] = item;
        }

    }
    string[] result = new string[i];

    for (int j = 0; j < result.Length; j++)
    {
        result[j] = lessThen3digit[j];
    }

    return result;
}

while (true)
{
    Console.Write("Заполните массив строк.");
    Console.WriteLine($"Только эти элементы вашего массива не длиннее трех символов : {string.Join(", ", SortStrings(EnterAndSplitString()))}");

    Console.WriteLine("Enter чтобы продолжить / q чтобы выйти");
    ConsoleKeyInfo quite = Console.ReadKey();
    Console.Clear();
    if (quite.KeyChar == 'q' || quite.KeyChar == 'й') break;
}
