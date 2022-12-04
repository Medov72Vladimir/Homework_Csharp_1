// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

Console.WriteLine("Введите трёхзначное число ");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);
if (number > 99)
{
    while (number > 999)
        //Переводим введенное число в трехзначное
        number = (number /= 10);
        // Определяем третью цифру (остаток от деления на 10)
        int result = (number % 10);
    Console.WriteLine($"Третья цифра заданного числа: {result}");
}
else Console.WriteLine("Число должно быть больше 100!");
