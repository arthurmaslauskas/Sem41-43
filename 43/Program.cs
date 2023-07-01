// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
//  y = k1 * x + b1 y = k2 * x + b2 значения b1, k1, b2 и k2 задаются пользователем.
using System;
using static System.Console;

WriteLine("Write b1");
double b1 = Convert.ToInt32(ReadLine());
WriteLine("Write k1");
double k1 = Convert.ToInt32(ReadLine());
WriteLine("Write b2");
double b2 = Convert.ToInt32(ReadLine());
WriteLine("Write k2");
double k2 = Convert.ToInt32(ReadLine());

double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;

WriteLine($"2 number an A to B  X: {x}, Y: {y}");