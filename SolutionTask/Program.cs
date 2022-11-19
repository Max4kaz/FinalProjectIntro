Console.Clear();
string[] initialArray = { "hello", "2", "world", ":-)" };   // { "hello", "2", "world", ":-)" } ||  { "1234", "1567", "-2", "computer science" } ||  { "Russia", "Denmark", "Kazan" }
int amountSymbols = 3;
int countString = CountStringLessAmountSymbols(initialArray, amountSymbols);
string[] formedArray = FormStringArray(initialArray, countString, amountSymbols);
Console.WriteLine("Исходный массив: ");
PrintArray(initialArray);
Console.WriteLine($"Сформированный массив, из строк длина которых меньше или равна {amountSymbols} символа: ");
PrintArray(formedArray);

int CountStringLessAmountSymbols(string[] array, int number)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= number) count++;
    }
    return count;
}

string[] FormStringArray(string[] array, int count, int number)
{
    string[] result = new string[count];
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if (array[i].Length <= number)
        {
            result[j] = array[i];
            j++;
        }
    }
    return result;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}. ");
    }
    Console.WriteLine();
    Console.WriteLine();
}
