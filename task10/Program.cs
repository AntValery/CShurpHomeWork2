﻿Console.Write("Введите трёхзначное число = ");
int n = Convert.ToInt32(Console.ReadLine());

n = (n / 10) % 10;
Console.WriteLine(n);