// Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. Напишите 
// программу, которая покажет количество чётных чисел в 
// массиве.

// [345, 897, 568, 234] -> 2

int GetNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}


int[] FillArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
    return array;
}

void EvenNumQty(int[] array)
{
    int count = 0;
    foreach(int el in array)
    {
        if(el % 2 == 0)
        {
            count++;
        }
    }
    Console.Write($"Количество четных чисел в массиве = {count}.");
}

int size = GetNum("Введите длину массива: ");
int minValue = 100;
int maxValue = 999;

int[] arr = FillArray(size, minValue, maxValue);
Console.WriteLine(string.Join(" ", arr));

EvenNumQty(arr);