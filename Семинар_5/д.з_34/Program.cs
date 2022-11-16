//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2


int GetNumberOfPositive(int[] array)
{

    int sum = 0;

    for (int i = 0; i <= array.Length -1 ; i++)
    {
        if ( array[i] == array[i] / 2 * 2 ) sum = sum + 1;    
    }
    return sum;
}


Console.Write("Введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());

int[] array = new int[a]; 

for (int i = 0; i <= array.Length - 1; i++)
{
    array[i] = new Random().Next(100, 1000);
}

Console.Write($"Массив из {a} элемента(ов) заполнен значениями: ");

for (int i = 0; i <= array.Length -1 ; i++)
{
   Console.Write(array[i] + ", ");
}

Console.WriteLine();
int sum = GetNumberOfPositive(array);
Console.Write($"Количество четных чисел в массиве: {sum}");

