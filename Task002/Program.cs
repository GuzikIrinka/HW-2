// Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.
// 645 -> 6
// 78 -> третьей цифры нет
// 32679 -> 6

using System;
using static System.Console;

WriteLine ("Введите число: ");

int Num = Convert.ToInt32(ReadLine ());

WriteLine ((Num/100)%10);
