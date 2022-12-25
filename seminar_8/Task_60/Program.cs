﻿/*Задача 60.
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
int[,,] arrayCube = new int[2, 2, 2];
    for (int i = 0; i < arrayCube.GetLength(0); i++)
    {
        for (int j = 0; j < arrayCube.GetLength(1); j++)
        {
            for ( int k = 0; k < arrayCube.GetLength(2); k++)
            {
                arrayCube[i, j, k] = new Random().Next(10, 99);
                Console.Write($"{arrayCube[i, j, k]}({i},{j},{k}) ");
            }
        Console.WriteLine();
        }
    }