// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите положительное число N: ");
int number = Convert.ToInt32(Console.ReadLine());
if ( number > 0)
{
for (int i = 2; i <= number; i+=2) Console.Write($"{i}, ");
}
else
{
Console.WriteLine("Вы ввели отрицательное число!");
}
