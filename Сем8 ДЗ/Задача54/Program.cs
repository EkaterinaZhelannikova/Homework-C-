//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Clear();

Console.Write("Введите количество строк массива: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов массива: ");
int column = int.Parse(Console.ReadLine()!);
int[,] array = new int[row, column];

FillArray(array);
PrintArray(array);

Console.WriteLine("Отсортированный массив: ");
OrderDecreaseArray(array);
PrintArray(array);

void OrderDecreaseArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                { 
                    int number = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = number;
                }
            }
        }
    }
}

void FillArray(int[,] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}