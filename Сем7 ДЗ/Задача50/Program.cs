//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//1
//7 -> такого числа в массиве нет

Console.Clear();

int[,] array = new int[4, 4];
FillArray(array);
PrintArray(array);

Console.Write("Введите позицию элемента массива: ");
Console.WriteLine();
int i = int.Parse(Console.ReadLine()!);
int j = int.Parse(Console.ReadLine()!);

if (i < array.GetLength(0) && j < array.GetLength(1))
{
    Console.WriteLine($"Значение это элемента: {array[i,j]}");
}
else
{
    Console.WriteLine("Числа с такой позицией элемента в массиве нет");
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}
 
void FillArray(int[,] array)
{
    Random generator = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = generator.Next(1,10);
        }
    }
}
