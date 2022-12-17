// Задача 43.
// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// Значения b1, k1, b2 и k2 задаются пользователем.
Console.WriteLine("Введите число k1 ->  ");
double numberK1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b1 ->  ");
double numberB1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число k2 ->  ");
double numberK2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b2 ->  ");
double numberB2 = Convert.ToInt32(Console.ReadLine());
double X = 0;
double Y = 0;
if ((numberK2 - numberK1) != 0)
{
   X = Math.Round(((numberB1 - numberB2) / (numberK2 - numberK1)), 2);
   Y = Math.Round((numberK2 * X + numberB2), 2);
   Console.WriteLine($"Координаты точки пересечения: x = {X}, y = {Y}");
}
else Console.WriteLine("Данные прямые не пересекаются");
