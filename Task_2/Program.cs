// Напишите программу, которая на вход принимает два числа 
// и выдаёт, какое число min, а какое max.

Console.WriteLine("Введите число А: ");
int NumberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int NumberB = Convert.ToInt32(Console.ReadLine());

if (NumberA > NumberB)
{
    Console.WriteLine($"Max число A: {NumberA}");
}
else if (NumberA < NumberB)
{
    Console.WriteLine($"Max число B: {NumberB}");
}
else
{
    Console.WriteLine($"Числа A и B одинаковые: {NumberA}");
}
