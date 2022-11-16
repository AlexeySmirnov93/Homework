//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

double DifferenceBetweenMaxAndMin (double[] array)
{

    double max = array[0];
    double min = array[0];

    for (int i = 0; i <= array.Length -1 ; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i]; 
    }
    double result = max - min;
    return result;    
}

Console.Write("Введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());

double[] array = new double[a]; 

for (int i = 0; i <= array.Length - 1; i++)
{
    array[i] = new Random().NextDouble() + new Random().Next(1, 10);
}

Console.Write($"Массив из {a} элемента(ов) заполнен значениями: ");

for (int i = 0; i <= array.Length -1 ; i++)
{
   Console.Write(array[i] + ", ");
}

Console.WriteLine();
double result = DifferenceBetweenMaxAndMin(array);
Console.Write($"разницa между максимальным и минимальным элементов массива: {result}");