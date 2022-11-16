//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N
Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int min = 1;
if (N <= min)
{
    Console.WriteLine($" Нет четных числел из числа: {N}.");
}
else
{
    while (min <= N)
{
    if (min % 2 == 0)
    {
        Console.WriteLine($"Число: {min}, четное из числа: {N}.");
        min++;
    }
    else
    { 
        min++;
    }
    
} 
}