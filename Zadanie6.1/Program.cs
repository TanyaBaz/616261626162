﻿int Promt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int[] inputArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Promt($"Введите {i + 1}-й элемент");
    }
    return array;
}

void PrintArray(int[] array)
{
     for (int i = 0; i < array.Length; i++)
     {
        Console.WriteLine($"a[{i}] = {array[i]}");
     }
}

int CountPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}
int length = Promt("Введите количество элементов >");
int[] array;
array = inputArray(length);
PrintArray(array);
Console.WriteLine($"Количество чисел больше 0 - {CountPositiveNumbers(array)}");
