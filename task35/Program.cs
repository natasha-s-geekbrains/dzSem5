// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в 
// отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


int GetNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");
    Console.WriteLine();
}

void ShowResult(int[]array, int newMin, int newMax)
{
    int count = 0;
    foreach(int el in array)
    {
        if (el >= newMin && el <= newMax)
        {
            count++;
        }
    }
    Console.Write($"Количество элементов массива, значения которых лежат в отрезке [10,99] = {count}");
}

int arrSize = 123;
int minValue = GetNum("Введите значение нижней границы массива: ");
int maxValue = GetNum("Введите значение верхней границы массива: ");

//Console.Write($"{arrSize}, {minValue}, {maxValue}");
int[] arr = GetArray(arrSize, minValue, maxValue);
PrintArray(arr);

int newMin = 10;
int newMax = 99;

ShowResult(arr, newMin, newMax);
