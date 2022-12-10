//  Задача 27
//  Напишите программу, которая принимает на вход число
//  и выдаёт сумму цифр в числе.

      Console.Write("Введите число -> ");
      string? number = Convert.ToString(Console.ReadLine());
      int[] array = new int[number!.Length];
      int sum = 0;
      int i;
      for (i = 0; i < number.Length; i++)
      {
        array[i] = (int)char.GetNumericValue(number[i]);
         sum += array[i]; 
      }
      Console.WriteLine($"Сумма цифр числа {number} = {sum}");
   