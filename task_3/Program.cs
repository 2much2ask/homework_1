﻿/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).*/


Console.Clear();

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

if (number % 2 == 0) Console.WriteLine($"число {number} является четным");
else Console.WriteLine($"число {number} является нечетным");