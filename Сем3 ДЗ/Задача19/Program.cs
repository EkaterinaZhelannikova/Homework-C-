//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да

Console.Clear();

Console.Write("Введите пятизначное число: ");
string number = Console.ReadLine()!;

if ((number.Length < 5) || (number.Length > 5))
{
    Console.Write("Число не является пятизначным");
}
else 
{
    if ((number[0] == number[4]) && (number[1] == number[3]))
    {
        Console.Write("Число является палиндромом");
    }
    else
    {
        Console.Write("Число НЕ является палиндромом");
    }
}