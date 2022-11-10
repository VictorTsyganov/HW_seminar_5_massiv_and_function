// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();

double[] GetArray(int size)
{
    double[] res = new double[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = Math.Round(new Random().NextDouble(), 2);
        Console.Write($"{res[i]} ");
    }
    return res;
}
double[] array = GetArray(6);

Console.WriteLine();

double DifferenceMinMax(double[] mass)
{
    double min = mass[0];
    double max = mass[0];
    foreach (double item in mass)
    {
        min = item < min ? item : min;
        max = item > max ? item : max;
    }
    Console.WriteLine($"Минимальное значение: {min}");
    Console.WriteLine($"Максимальное значение: {max}");
    double diff = max - min;
    return diff;
}

Console.WriteLine($"Разница между max и min значениями массива: {DifferenceMinMax(array)}");
