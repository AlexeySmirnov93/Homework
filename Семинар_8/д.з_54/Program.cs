﻿//Задайте двумерный массив. 
//Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

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
void GetStringDescendingOrder(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {   
        

        for (int j = 0; j < array.GetLength(1); j++)
        {   
           for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }   
    }
}
void GetPrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {   

        for (int j = 0; j < array.GetLength(1); j++)
        {   
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();

    }
}

Console.WriteLine("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] array = new int[m, n];

FillArrayRandom(array);
GetStringDescendingOrder(array);
Console.WriteLine();
GetPrintArray(array);
