/* Напишите программу, которая принимает на вход трёхзначное число 
 и на выходе показывает вторую цифру этого числа*/

Console.WriteLine("Введите трёхзначное число ");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);
if ((number >= 100) && (number <= 999))
{
   Console.WriteLine($"Вторая цифра числа = {(number / 10) % 10}"); 
}
else Console.Write("Допущена ошибка при вводе числа");
