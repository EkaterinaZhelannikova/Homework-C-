//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
//Ограничения:
//- Нельзя использовать класс Math
//- Должна быть отдельная функция Power, которая возвращает результат
//- Внутри функций НЕЛЬЗЯ использовать класс Console. Только в основном блоке кода

Console.Clear();

Console.Write("Введите число А: ");
int numberA = int.Parse(Console.ReadLine()!);
Console.Write("Введите число B: ");
int numberB = int.Parse(Console.ReadLine()!);

int pow = Power(numberA, numberB);
Console.Write($"{pow}");

int Power(int numberA, int numberB)
{
    int result = 1;
    for (int i = 0; i < numberB; i++)
    {
        result = result * numberA;
    }
    return result;
}