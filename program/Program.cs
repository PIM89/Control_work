Console.Write("Введите данные в массив через запятую: ");
string text = Console.ReadLine();
string[] array = text.Split(',', ' ');
string temp = string.Empty;

string[] SortElem(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length > 0 && array[i].Length <= 3) temp += $"{array[i]}, ";
    }
    string[] new_array = temp.Split(',');
    return new_array;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length - 1; i++) Console.Write($"{array[i]},");
}

PrintArray(SortElem(array));
