//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
//Заполнение массива производит пользователь.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

System.Console.WriteLine("Введите количество элементов массива: ");

int a = Convert.ToInt32(Console.ReadLine());

int[] array = new int[a]; 

for (int i = 0; i <= array.Length - 1; i++)
{
    Console.Write($"Введите элементы массива под номером {i}: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

 Console.Write($"Массив из {a} элемента(ов) заполнен значениями: ");

for (int i = 0; i <= array.Length -1 ; i++)
{
    Console.Write(array[i] + ", ");
}

