// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
int[] array = GetArray(6, -9, 9);

Console.WriteLine();

int SummNumbersEvenPos(int[] mass)
{
    int length = mass.Length;
    int summ = 0;
    for (int i = 0; i < length; i++)
    {
        if (i % 2 != 0) summ = summ + mass[i];
    }
    return summ;
}
Console.WriteLine(SummNumbersEvenPos(array));