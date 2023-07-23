// Задача 36: Задайте одномерный массив, заполненный 
// случайными числами. Найдите сумму элементов, стоящих 
// на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


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
        array[i] = new Random().Next(minValue, maxValue+1);
    }
    return array;
}

void GetOddIdxNumSum(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    Console.Write($"Сумма элементов, стоящих на нечётных позициях = {sum}.");
}

int arrSize = GetNum("Введите длину массива: ");
int arrMin = GetNum("Введите значение нижней границы массива: ");
int arrMax = GetNum("Введите значение верхней границы массива: ");

int[] arr = FillArray(arrSize, arrMin, arrMax);

Console.Write(string.Join(", ", arr));
Console.WriteLine();
GetOddIdxNumSum(arr);
