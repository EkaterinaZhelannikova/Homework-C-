//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.Clear();

Console.Write("Введите количество строк 1 матрицы: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов 1 и количество строк 2 матриц: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов 2 матрицы: ");
int p = int.Parse(Console.ReadLine()!);

int[,] firstMatrix = new int[m, n];
FillArray(firstMatrix);
Console.WriteLine($"Первая матрица:");
PrintArray(firstMatrix);

int[,] secondMatrix = new int[n, p];
FillArray(secondMatrix);
Console.WriteLine($"Вторая матрица:");
PrintArray(secondMatrix);

int[,] resultMatrix = new int[m,p];

MultiplyMatrix(firstMatrix, secondMatrix, resultMatrix);
Console.WriteLine($"Произведение двух матриц:");
PrintArray(resultMatrix);

void MultiplyMatrix(int[,] firstMatrix, int[,] secondMatrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                sum += firstMatrix[i,k] * secondMatrix[k,j];
            }
        resultMatrix[i,j] = sum;
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