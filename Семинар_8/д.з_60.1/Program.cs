//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)

void PrintArrayRandom(int[,,] array)
{
    
    for (int k = 0; k < array.GetLength(2); k++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(0); j++)
            {
                array[i, j, k] = new Random().Next(10, 100);
                Console.Write($"{array[i, j, k]} [{i},{j},{k}] ");
            }Console.WriteLine();
        }
        
    }Console.WriteLine();

}Console.WriteLine();



Console.Write("Введите размерность M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите размерность N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите размерность D: ");
int d = Convert.ToInt32(Console.ReadLine());

int[,,] array = new int[m, n, d];

System.Console.WriteLine("Массив сформирован: ");

PrintArrayRandom(array);
