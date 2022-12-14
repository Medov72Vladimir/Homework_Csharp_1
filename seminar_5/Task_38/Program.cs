// Задача 38.
// Задайте массив вещественных чисел. Найдите разницу между максимальным
// и минимальным элементами массива.
// [3 7 22 2 78] -> 76

Console.Write("Введи число равное длине массива -> ");
var longArray = Convert.ToUInt32(Console.ReadLine());
double[] array = new double [longArray!];
Random rnd = new Random();
Console.Write("Массив -> [ ");
for (int i = 0; i < longArray; i++)
{
    array[i] = Math.Round(new Random().NextDouble() *100, 2);
    Console.Write(array[i] + " ");
}
Console.WriteLine("]"); 
double minNumber = array[0];
double maxNumber = array[0];
for (int i = 0; i < longArray; i++)
{
    if ( array[i] > maxNumber) maxNumber = array[i];
    if ( array[i] < minNumber) minNumber = array[i];
}
double result = maxNumber - minNumber;
Console.WriteLine($"Разница между max и min элементами массива -> {Math.Round(result,2)}");
