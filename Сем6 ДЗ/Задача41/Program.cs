//Пользователь вводит с клавиатуры число M, потом вводит M чисел ЧЕРЕЗ ENTER. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//5 0 7 8-2 -2 -> 2
//5 1 -7 567 89 223 -> 

Console.Clear();

Console.Write($"Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int count = 0;

Console.WriteLine($"Введите числа через Enter");
for (int i = 0; i < number; i++)
{
    int currentNumber = int.Parse(Console.ReadLine()!);
    if (currentNumber > 0)
    {
        count++;
    }
}

Console.Write($"Количество чисел больше 0 равно: {count}");

