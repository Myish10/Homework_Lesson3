﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int InputNum(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine()!);
    return num;
}

int number = InputNum("Введите целое число: ");

for (int i = 1; i <= number; i++)
{
    Console.Write($"{Math.Pow(i, 3)}");
    if (i < number)
        Console.Write(", ");
    else
        Console.Write(".");
}