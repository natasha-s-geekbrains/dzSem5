// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний 
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int GetNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[] FillArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
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

int[] ModifyArray(int[] array)
{
    int newArrSize = 0;
    if (array.Length % 2 == 0)
    {
        newArrSize = array.Length / 2;
    }
    else
    {
        newArrSize = array.Length / 2 + 1;
    }
    int[] resultArr = new int[newArrSize];

    if (array.Length % 2 == 0)
    {
        for (int j = 0; j < newArrSize; j++)
        {
            resultArr[j] = array[j] * array[array.Length - 1 - j];
        }
    }
    else
    {
        for (int j = 0; j < newArrSize; j++)
        {
            resultArr[j] = array[j] * array[array.Length - 1 - j];
            resultArr[newArrSize - 1] = array[array.Length / 2];
        }
    }
    return resultArr;
}

int arrSize = GetNum("Введите длину массива: ");
int arrMinValue = GetNum("Введите значение нижней границы массива: ");
int arrMaxValue = GetNum("Введите значение верхней границы массива: ");

int[] arr = FillArray(arrSize, arrMinValue, arrMaxValue);

PrintArray(arr);

int[] resultArray = ModifyArray(arr);
PrintArray(resultArray);

