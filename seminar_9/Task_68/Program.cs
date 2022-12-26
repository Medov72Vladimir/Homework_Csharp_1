// Задача 68.
// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите число m ->  ");
int M = int.Parse(Console.ReadLine());
Console.Write("Введите число n ->  ");
int N = int.Parse(Console.ReadLine());

int FunctionAkkerman(int numM, int numN)
{
if (numM == 0) return numN + 1;
if (numM > 0 && numN == 0) return FunctionAkkerman(numM - 1, 1);
if (numM > 0 && numN > 0) return
   FunctionAkkerman(numM - 1, FunctionAkkerman(numM, numN - 1));
   return FunctionAkkerman(M, N);
}
Console.WriteLine($"Функция Аккермана для чисел m={M} и n={N} равна {FunctionAkkerman(M, N)} ");
