// Задача 38: Задайте массив вещественных чисел. Найдите 
// разницу между максимальным и минимальным 
// элементов массива.

// [3 7 22 2 78] -> 76

int GetNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

double[] FillArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().NextDouble();
        array[i] = Math.Round(array[i], 3);
    }
    return array;
}

void GetDiff(double[] array)
{
    double minValue = array[0];
    double maxValue = array[0];

    foreach (double el in array)

    {
        if (minValue > el) minValue = el;
        if (maxValue < el) maxValue = el;
    }
    Console.Write($"Разница между максимальным и минимальным элементами массива = {maxValue-minValue}.");
}

int arrSize = GetNum("Введите длину массива: ");
double[] arr = FillArray(arrSize);
Console.Write(string.Join(" | ", arr));
Console.WriteLine();

GetDiff(arr);