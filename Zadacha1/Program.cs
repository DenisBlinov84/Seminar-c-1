﻿// На вход принимает одно число N, а на выходе показывает все целые числа
// в промежутке от -N до N.

string s = Console.ReadLine();
int x = int.Parse(s);
int y = -x;
while (y <= x)
{
    Console.Write($"{y} ");
    y = y + 1;
}

