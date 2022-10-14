//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Рекурсивно
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

Console.Clear();

Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);

Console.Write($"Сумма элементов от {m} до {n} равна {SumNaturalNumbers (m, n)}");

int SumNaturalNumbers (int m, int n)
{
    if(m == n) return n;
    return n + SumNaturalNumbers(m, n - 1);
}