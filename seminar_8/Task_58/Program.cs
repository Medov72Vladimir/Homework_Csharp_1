/*Задача 58.
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
int[,] array1 = new int[2, 2];
int[,] array2 = new int[2, 2];
void FillArrayRandom(int[,] array)//метод заполнение массива m+n случайными числами
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}
FillArrayRandom(array1);
FillArrayRandom(array2);

void PrintArray(int[,] array)//метод вывода на консоль массива m+n
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Массив 1");
PrintArray(array1);
Console.WriteLine("Массив 2");
PrintArray(array2);

int[,] compositionArrays = new int[2, 2];
for (int i = 0; i < array1.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        compositionArrays[i, j] = 0;
        for (int k = 0; k < array1.GetLength(1); k++)
        {
            compositionArrays[i, j] += array1[i, k] * array2[k, j];
        }
    }
}
Console.WriteLine("Произведение массивов");
PrintArray(compositionArrays);