const int TARGET_LENGTH = 3;
string[] array = {"qwe", "qwerty", "asd", "asdfgh", "zxc", "zxcvb", "", "1", "12"};

int FindLength(string[] arr)
{
    int s = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= TARGET_LENGTH)
        {
            s++;
        }
    }
    return s;
}

string[] FilteredArray(string[] arr)
{
    int size = FindLength(arr);
    string[] result = new string[size];
    int index = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= TARGET_LENGTH)
        {
            result[index] = arr[i];
            index++;
        }
    }
    return result;
}

void PrintArray(string[] arr)
{
    foreach (var item in arr)
    {
        Console.Write($"{item}\t");
    }
}

PrintArray(FilteredArray(array));