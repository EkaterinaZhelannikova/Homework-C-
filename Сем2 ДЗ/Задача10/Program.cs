//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

Console.Clear();

Console.Write("Введите число: ");
string number = Console.ReadLine();

if(number.Length == 3)
{
    Console.Write($"{number[1]}");
}
else
{
    Console.WriteLine("Число не является трехзначным");
}