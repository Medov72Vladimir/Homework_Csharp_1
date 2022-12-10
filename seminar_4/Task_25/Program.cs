//  Задача 25
//  Напишите цикл, который принимает на вход два числа (A и B) 
 // и возводит число A в натуральную степень B.

Console.Write("Введите число основания А -> ");
double footingA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число степени В -> ");
double degreeB = Convert.ToInt32(Console.ReadLine());
double result = 1;
if (degreeB > 0)
{ 
    for(int i = 1; i <= degreeB; i++)
   {
        result *= footingA;
   }
}
else
{
    for(int i = 1; i <= Math.Abs(degreeB); i++)
    { 
       result *= 1 / footingA; 
    }  
}
Console.WriteLine($"Результат равен = {result}");