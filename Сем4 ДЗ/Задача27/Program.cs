//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
//Ограничения:
//- Должна быть отдельная функция, которая возвращает результат суммы цифр
//- Внутри функций НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода

Console.Clear();

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int sum = Sum(number);
Console.Write($"Сумма цифр в числе равна {sum}");

int Sum (int number)
{
    int length = Convert.ToString(number).Length;
    int sum = 0;
    for (int i = 0; i < length; i++)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    return sum;
}
