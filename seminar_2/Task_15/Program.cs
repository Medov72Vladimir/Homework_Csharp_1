// Напишите программу, которая принимает на вход цифру, обозначающую 
//  день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число, обозначающее день недели (1 - 7)");
int day_week = Convert.ToInt32(Console.ReadLine());
if ((day_week > 0) && (day_week < 6))
{
    Console.WriteLine("Будни...");
}
else if (day_week == 6 || day_week == 7) 
{
    Console.WriteLine("Выходной!");
} 
else Console.WriteLine("Ошибка при вводе числа!");
