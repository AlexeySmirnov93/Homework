// Задача 64: Задайте значение N. 
// Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

int GetNatural(int n)
{

    if (n == 1)
    {
        return 1;
    }
    Console.WriteLine(n);
    return GetNatural(n - 1);
}

Console.WriteLine("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int f = GetNatural(n);
Console.WriteLine(f);