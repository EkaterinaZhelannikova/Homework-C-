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

int Sum (int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    return sum;
}
