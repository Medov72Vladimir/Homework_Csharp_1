/* Напишите программу, которая принимает на вход трёхзначное число 
 и на выходе показывает вторую цифру этого числа*/

Console.WriteLine("Введи трёхзначное число");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);
int res = (number / 10) %10;
Console.WriteLine($" Вторая цифра числа = {res}");
