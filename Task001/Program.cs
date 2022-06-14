// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

using System;
using static System.Console;

Clear ();

WriteLine ("Введите трехзначное число: ");

int number = Convert.ToInt32 (ReadLine());

int ost1 = number %100/10;

WriteLine ($"Вторая цифра трехзначного числа: {ost1}");
