// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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
int[] array = GetArray(7, 1, 10);

Console.WriteLine();

int[] NewArray(int[] mass)
{
    int[] newMass = new int[mass.Length / 2 + 1];
    for (int i = 0; i < mass.Length / 2; i++)
        {
            newMass[i] = mass[i] * mass[mass.Length - 1 - i];
            Console.Write($"{newMass[i]} ");
        }
    if (mass.Length % 2 != 0)
    {
        newMass[mass.Length / 2] = mass[mass.Length / 2];
        Console.Write($"{newMass[mass.Length / 2]} ");
    }
    return newMass;
}

NewArray(array);