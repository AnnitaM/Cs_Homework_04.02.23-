﻿// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27 
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.Write("Введите число: ");
int num = Int32.Parse(Console.ReadLine());
int i = 1;

if (num < 0)
{
    i = num;
    num = -1;
}

for (; i <= num; i++)
{
    Console.Write($"{Math.Pow(i, 3)} ");
}
