//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

Console.Write("Введите координату X для A: ");
int xa = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату Y для A: ");
int ya = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату Z для A: ");
int za = int.Parse(Console.ReadLine()!);

Console.Write("Введите координату Х для B: ");
int xb = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату Y для B: ");
int yb = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату Z для B: ");
int zb = int.Parse(Console.ReadLine()!);


double d = Math.Sqrt (Math.Pow(xa - xb, 2) + Math.Pow(ya - yb, 2) + Math.Pow(za - zb, 2));
Console.Write($"расстояние между точками = {d:f2}");