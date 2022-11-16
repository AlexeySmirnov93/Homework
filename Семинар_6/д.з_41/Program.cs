//Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//-1, -7, 567, 89, 223-> 3


int GetSearchForValues(int[] array, int b)
{
    int sum = 0;

    for (int i = 0; i <= array.Length -1 ; i++)
    {
        if ( array[i] > b ) sum = sum + 1;    
    }
    return sum;
}


Console.Write("Введите количество элементов: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число, больше кторого хотите найти: ");
int b = Convert.ToInt32(Console.ReadLine());

int[] array = new int[a]; 

for (int i = 0; i <= array.Length - 1; i++)
{
    Console.Write($"Введите число под номером {i + 1}: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.Write($"Количество элементов {a}, заполнены значениями: ");

for (int i = 0; i <= array.Length -1 ; i++)
{
   Console.Write(array[i] + ", ");
}

Console.WriteLine();
int sum = GetSearchForValues(array,b);
Console.Write($"Количество чисел больше {b} = {sum}");


