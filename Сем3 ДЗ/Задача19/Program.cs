//Напишите программу, которая принимает на вход пятизначное число и проверяет,
//является ли оно палиндромом.
//14212 -> нет
//12821 -> да

//Console.Write("Введите пятизначное число: ");
//string number = Console.ReadLine()!;
//if ((number.Length < 5) || (number.Length > 5))
//{
//    Console.Write("Число не является пятизначным");
//}
//else 
//{
//    if ((number[0] == number[4]) && (number[1] == number[3]))
//    {
//        Console.Write("Число является палиндромом");
//    }
//    else
//    {
//        Console.Write("Число НЕ является палиндромом");
//    }
//}

Console.Clear();

Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine()!);

int first = number / 10000 % 10;
int second = number / 1000 % 10;
int fourth = number / 10 % 10;
int fifth = number % 10;

if ((number < 10000) || (number > 99999))
{
    Console.Write("Число не является пятизначным");
}
else 
{
    if ((first == fifth) && (second == fourth))
    {
        Console.Write("Число является палиндромом");
    }
    else
    {
        Console.Write("Число НЕ является палиндромом");
    }
}