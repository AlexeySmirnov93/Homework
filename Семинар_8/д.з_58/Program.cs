// Задайте две матрицы. 
//Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18




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

Console.WriteLine("Введите кол-во строк : ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов: ");
int y = Convert.ToInt32(Console.ReadLine());
int[,] arrayMatrix1 = new int[x, y];
int[,] arrayMatrix2 = new int[x, y];
int[,] result = new int[x, y];

Console.WriteLine("Матрица №1: ");
FillArrayRandom(arrayMatrix1);
Console.WriteLine("Матрица №2: ");
FillArrayRandom(arrayMatrix2);
Console.WriteLine("Результат произведение двух матриц: ");

for (int i = 0; i < arrayMatrix1.GetLength(0); ++i)
{
    for (int j = 0; j < arrayMatrix2.GetLength(1); ++j)
    {
        for (int k = 0; k < arrayMatrix2.GetLength(1); ++k)
        {
            result[i, j] = result[i, j] + (arrayMatrix1[i, k] * arrayMatrix2[k, j]);
        }   Console.Write(result[i, j] + " ");
        
        
    }Console.WriteLine();
}