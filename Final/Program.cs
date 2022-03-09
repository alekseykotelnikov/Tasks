Console.Clear();
string[] GetNewArray(string[] firstArray)
{
    string[] newArray = new string[firstArray.Length];
    int realSize = 0;
    for (var i = 0; i < firstArray.Length; i++)
    {
        if (firstArray[i].Length <= 3)
        {
            newArray[realSize] = firstArray[i];
            realSize++;
        }
    }
    Array.Resize(ref newArray, realSize);
    return newArray;
}

// int FindNewSize(string[] firstArray)
// {
//     int realSize = 0;
//     for (var i = 0; i < firstArray.Length; i++)
//     {
//         if (firstArray[i].Length <= 3)
//         {
//             realSize++;
//         }
//     }
//     return realSize;
// }
// string[] GetNewArray(string[] firstArray, int realSize)
// {
//     string[] newArray = new string[realSize];
//     int count = 0;
//     foreach (var item in firstArray)
//     {
//         if (item.Length <= 3)
//         {
//             newArray[count] = item;
//             count++;
//         }
//     }
//     return newArray;
// }

void PrintArray(string[] array)
{
    foreach (var item in array)
    {
        Console.Write($"{item} ");
    }
}

string[] firstArray = { "Sergey", ",", "thank", "you", "for", "teaching", "!" };
string[] newArray = GetNewArray(firstArray);
// string[] newArray = GetNewArray(firstArray, arraySize);
Console.WriteLine("Задан следующий массив строк:");
PrintArray(firstArray);
Console.WriteLine();
// Console.WriteLine($"В этом массиве, количество строк с симоволами <= 3, будет {arraySize}");
Console.WriteLine("Новый массив выглядит так:");
PrintArray(newArray);