// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
void ReadInt(string text)
{
    System.Console.WriteLine(text);
}
int CountPositiveNum(int[] tempArray)
{
    int count = 0;
    for (int i = 0; i < tempArray.Length; i++)
    {
        if (tempArray[i] % 2 == 0)
        {
            count += 1;
        }

    }
    return count;
}

void PrintArray(int[] arrayForPrint, int count)
{
    System.Console.WriteLine("[" + string.Join(" | ", arrayForPrint) + "]" + "->" + count);
}
ReadInt("Введите числа через пробел: ");
int[] array = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
int count = CountPositiveNum(array);
PrintArray(array, count);
