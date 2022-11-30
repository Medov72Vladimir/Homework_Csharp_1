// Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите число A: ");
int NumberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int NumberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число C: ");
int NumberC = Convert.ToInt32(Console.ReadLine());

int max = NumberA;

if (max < NumberB)
{
    max = NumberB;
}
if (max < NumberC)
{
    max = NumberC;
Console.WriteLine($"Максимальное число: {max}");
}
else
{
    Console.WriteLine($"Числа A,B,C одинаковые: {max}");
}