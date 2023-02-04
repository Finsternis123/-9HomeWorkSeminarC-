// Выполнить с помощью рекурсии.Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.WriteLine("Enter number A"); 
int A = Convert.ToInt32(Console.ReadLine()!); 
Console.WriteLine("Enter number B"); 
int B = Convert.ToInt32(Console.ReadLine()!); 
Console.WriteLine(GetSum(A,B)); 
  
int GetSum(int A, int B) 
{  
    if (A == B) return A;
    return (A + GetSum(A + 1, B)); 
}