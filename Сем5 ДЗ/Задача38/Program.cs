//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

Console.Clear();

double[] array = CreateArray(7);
double diffMaxMin = DiffMaxMin(array);
PrintArray(array);
Console.WriteLine($"Разница между max и min элементов массива равна {diffMaxMin}");

double[] CreateArray (int length)
{
    double[] array = new double[length];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(-50, 50) + Math.Round(rand.NextDouble(), 2);
    }
    return array;
}

void PrintArray (double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i == array.Length - 1)
        {
            Console.Write("]");
        }
        else
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine();
}

double DiffMaxMin (double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
        else if (array[i] < min)
            min = array[i];
    }
    dif = max - min;
    return dif;
}