﻿// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да 
//7 -> да 
//1 -> нет

int a = new Random().Next(1, 7);
Console.WriteLine($"{a}");

if (a > 5)
{ 
   if (a == 6) Console.WriteLine($"Да, {a}й день недели выходной, (Суббота)");
   if (a == 7) Console.WriteLine($"Да, {a}й день недели выходной, (Воскресенье)"); 
}
else
{
   if (a == 1) Console.WriteLine($"Нет, {a}й день недели рабочий, (Понедельник)");
   if (a == 2) Console.WriteLine($"Нет, {a}й день недели рабочий, (Вторник)");
   if (a == 3) Console.WriteLine($"Нет, {a}й день недели рабочий, (Среда)");
   if (a == 4) Console.WriteLine($"Нет, {a}й день недели рабочий, (Четверг)");
   if (a == 5) Console.WriteLine($"Нет, {a}й день недели рабочий, (Пятница)");
}
