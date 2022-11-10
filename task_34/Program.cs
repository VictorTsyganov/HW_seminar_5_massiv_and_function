// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{res[i]} ");
    }
    return res;
}
int[] array = GetArray(10, 100, 1000);

Console.WriteLine();

int EvenNumbersCount(int[] mass)
{
    int count = 0;
    foreach (int item in mass)
    {
        if (item % 2 == 0) count ++;
    }
    return count;
}

Console.WriteLine(EvenNumbersCount(array));