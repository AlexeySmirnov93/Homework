// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

//Например, задан массив:

//1 4 7 2

//5 9 2 3

//8 4 2 4

//5 2 6 7

//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void FillArrayRandom(int[,] array)
{ 
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int GetIndexMinSumSrt(int[,] array)
{
    int min= 0;
    int indexMin = 0;

    for (int j = 0; j < array.GetLength(1); j++)
    {
        min = min + array[0, j];
    }

    for (int i = 1; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        if (sum < min)
        {
            min = sum;
            indexMin = i;
        }
    }
    return indexMin;
}   
Console.WriteLine("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] array = new int[m, n];

FillArrayRandom(array);
Console.WriteLine();

int indexMin = GetIndexMinSumSrt(array);
Console.WriteLine($"Индек строки с наименьшей суммой элементов: {indexMin}");

