//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

Console.Clear();

Random rand = new Random();
int length = rand.Next(5, 7);
int[] array = CreateArray(length);
int dif = DiffMaxMin(array);
PrintArray(array);
Console.WriteLine($"Разница между max и min элементов массива равна {dif}");

int[] CreateArray (int length)
{
    int[] array = new int[length];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(-50, 50);
    }
    return array;
}

void PrintArray (int[] array)
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

int DiffMaxMin (int[] array)
{
    int max = array[0];
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
        else if (array[i] < min)
            min = array[i];
    }
    int dif = 0;
    if (min < 0)
        dif = max + min;
    else 
        dif = max - min;
    return dif;
}