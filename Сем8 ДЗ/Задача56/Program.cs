//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка (нумерация строк начинается с 1)

Console.Clear();

Console.Write("Введите количество строк массива: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов массива: ");
int column = int.Parse(Console.ReadLine()!);
int[,] array = new int[row, column];
FillArray(array);
PrintArray(array);

int indexRow = 1;
int minSumRow = SumRow(array, 0);

for (int i = 1; i < array.GetLength(0); i++)
{
    int tempSumRow = SumRow(array, i);
    if (minSumRow > tempSumRow)
    {
        minSumRow = tempSumRow;
        indexRow++;
    }
}

Console.WriteLine($"{indexRow} строкa с наименьшей суммой элементов ({minSumRow})");

int SumRow(int[,] array, int i)
{
    int sumRow = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sumRow += array[i,j];
    }
    return sumRow;
}

void FillArray(int[,] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(1, 10);
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