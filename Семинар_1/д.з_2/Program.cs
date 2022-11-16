// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее
Console.WriteLine("Введите число №1: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число №2: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB)
{
    Console.Write($"Число: {numberA} = Max  Число: {numberB} = Min");
}
else
{
    Console.Write($"Число: {numberA} = Min  Число: {numberB} = Max");   
}