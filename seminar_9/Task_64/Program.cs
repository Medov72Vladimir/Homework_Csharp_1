// Задача 64.
// Задайте значение N. Напишите программу, которая выведет все натуральные числа
// в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"

Console.Write("Введите число N ->  ");
int N = int.Parse(Console.ReadLine());
string SequenceNumber(int n)
{
if (n > 1)
{
    Console.Write(n + ", ");
     return SequenceNumber(n - 1);
}
else return n.ToString();
}
Console.WriteLine(SequenceNumber(N));
