﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Enter number: ");
int N = Convert.ToInt32(Console.ReadLine());

int result = 1;
for(int i = 1; i <= N; i++) 
{
result = i * i * i;
Console.Write(result + $",");
}
