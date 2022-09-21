//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Clear();

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
string digit = Convert.ToString(number);

if(digit.Length > 2)
{
    Console.Write($"{digit[2]}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}