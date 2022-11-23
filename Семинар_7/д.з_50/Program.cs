// Напишите программу, которая будет принимать от пользователя позицию (M, N) двумерного массива и возвращать значение элемента, стоящего в этой позиции.
//Если такой позиции в массиве нет, то сообщить об этом пользователю. Сгенерировать массив случайным образом. 
//Размерность массива определить самостоятельно. 
//Использование методов для заполнения массива обязательно. Остальное можно реализовать в главной программе.

//Например, задан массив:

//1 4 7 2

//5 9 2 3

//8 4 2 4

//M = 1, N = 7 -> В массиве отсутствует элемент в такой позиции.

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

void GetArrayElement(int[,] array, int M, int N)
{
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == M && j == N)
            {
                Console.Write($"(На позиции массива с индексом [{M},{N}] находится число {array[i, j]})");
            }
            
        }
    }
    
}

Console.WriteLine("Введите размерность M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите размерность N: ");
int n = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Массив сгенерирован:");

int[,] array = new int[m, n];
FillArrayRandom(array);




Console.WriteLine("Введите искомое M[i]: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите искомое N[i]: ");
int N = Convert.ToInt32(Console.ReadLine());
if(N >= 0 && M >= 0)
{
    
    if (n > N && m > M)
    {
        GetArrayElement(array, M , N);
    }
    else 
    {
        Console.WriteLine($"Позиции с индексом [{M},{N}] в массиве нет, максимальный индекс массива: [{m -1},{n -1}]");
    }
}
else
{
    System.Console.WriteLine( "Индекс начинается с [0,0]" );
}