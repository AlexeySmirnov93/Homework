//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0


int GetSumOfOddElements(int[] array)
{

    int sum = 0;

    for (int i = 1; i <= array.Length -1 ; i = i + 2)
    {
        sum =  array[i] + sum;    
    }
    return sum;
}


Console.Write("Введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());

int[] array = new int[a]; 

for (int i = 0; i <= array.Length - 1; i++)
{
    array[i] = new Random().Next(0, 10);
}

Console.Write($"Массив из {a} элемента(ов) заполнен значениями: ");

for (int i = 0; i <= array.Length -1 ; i++)
{
   Console.Write(array[i] + ", ");
}

Console.WriteLine();
int sum = GetSumOfOddElements(array);
Console.Write($"Сумма элементов, стоящих на нечётных позициях массиве: {sum}");