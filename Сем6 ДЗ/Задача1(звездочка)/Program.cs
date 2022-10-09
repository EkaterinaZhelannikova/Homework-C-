//Написать программу, которая рекурсивным методом переводит числа из десятичной системы счисления в двоичную
//2 -> 10
//11 -> 1011
//16 -> 10000

Console.Clear();

Console.Write($"Введите число: ");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Число {number} в двоичной системе исчисления: {Interpretation(number)}");


int Interpretation (int number)
{
    if (number == 0) return 0;
    else return (number % 2 + 10 * Interpretation(number / 2));
}