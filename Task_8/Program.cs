// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите положительное число N: ");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 2; i < number+1; i+=2) Console.Write($"{i} ");
