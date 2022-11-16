// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)
Console.WriteLine("Введите число №1: ");
int numberA = Convert.ToInt32(Console.ReadLine());

if (numberA % 2 == 0)
{
    Console.WriteLine($"Число: {numberA} четное");
}
else
{
    Console.WriteLine($"Число: {numberA} нечетное");
}