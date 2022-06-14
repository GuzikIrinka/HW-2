//  Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

using System;

using static System.Console;

WriteLine("Введите номер дня недели: ");

int Day = Convert.ToInt32(ReadLine ());

if (Day <6)
{
WriteLine("Рабочий день");
}
else if (Day == 6)
WriteLine("Суббота - выходной день");
else if (Day ==7)
WriteLine("Воскресенье - выходной день");

