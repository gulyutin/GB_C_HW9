﻿// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.

int n, m, s=0;
Console.Write("Введи M: ");
n = Convert.ToInt16(Console.ReadLine());
Console.Write("Введи N: ");
m = Convert.ToInt16(Console.ReadLine());
for (int i = n; i <= m; i++)
    s += i;
Console.WriteLine(s);