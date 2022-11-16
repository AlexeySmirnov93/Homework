//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел
Console.WriteLine("Введите число №1: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число №2: "); 
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число №3: ");
int numberС = Convert.ToInt32(Console.ReadLine());

int Max = numberA;

if (numberB > Max) Max = numberB;
if (numberС > Max) Max = numberС;

Console.Write($"Число: {Max} = Максимальное число");
