﻿// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Console.Write("Enter number n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Akkerman(n,m));           
int Akkerman(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return Akkerman(n - 1, 1);
    else
      return Akkerman(n - 1, Akkerman(n, m - 1));
}
            