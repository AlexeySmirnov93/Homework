//Запросите от пользователя размерности двумерного массива. 
//Напишите метод для заполнения массива случайными числами. 
//Напишите метод для поиска ср. арифметического значения каждого столбца.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

void GetTheArithmeticMeanOfColumn(int[,] array)
{

    for (int j = 0; j < array.GetLength(1); j++)
    {   
        double sum = 0;

        for (int i = 0; i < array.GetLength(0); i++)
        {  
            sum = sum + array[i, j];   
        }
        Console.WriteLine($"Среднее арифметическое столбца {j + 1} = {sum / array.GetLength(0)}");
    }

}

Console.WriteLine("Введите M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];

FillArrayRandom(array);

GetTheArithmeticMeanOfColumn(array);


     


