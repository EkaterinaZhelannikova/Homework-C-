// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7 min = 5
//a = 2 b = 10 -> max = 10 min = 2
//a = -9 b = -3 -> max = -3 min = -9


Console.Clear();

Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());

int max = Math.Max(number1, number2);
int min = Math.Min(number1, number2);

Console.Write($"max = {max}, min = {min}");
