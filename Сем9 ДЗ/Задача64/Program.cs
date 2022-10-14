//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
int counter = 1;

Console.Write($"N = {n} -> ");
Console.Write(NaturalNumbers (n, counter));

int NaturalNumbers (int n, int counter)
{
    if(n == counter) return n;
    else Console.Write($"{NaturalNumbers(n, counter + 1)} ");
    return counter;
}