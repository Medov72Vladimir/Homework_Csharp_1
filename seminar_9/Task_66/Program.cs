// Задача 66.
// Задайте значения M и N. Напишите программу, которая найдёт
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
Console.Write("Введите число M ->  ");
int M = int.Parse(Console.ReadLine());
Console.Write("Введите число N ->  ");
int N = int.Parse(Console.ReadLine());

int SumsSequenceNumber(int m, int n)
{
    if (m == n) return n;
    else return m + SumsSequenceNumber(m + 1, n);
}
Console.WriteLine($"Искомая сумма = {SumsSequenceNumber(M, N)}");