// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void PrintSquaresToConsole(int n)
{
    for (int i = 1; i <= n; i++)
    {
        System.Console.WriteLine(i * i * i);
    }

}
PrintSquaresToConsole(10);