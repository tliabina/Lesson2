﻿// Напишите программу, которая принимает на вход число и на выходе
// показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int  num = new Random ().Next(100,1000);
Console.WriteLine(num);

int result = (num / 10) % 10;

Console.WriteLine(result);
