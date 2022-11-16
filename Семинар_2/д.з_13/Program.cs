//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int c = a;
if (a > 99)
{
    while (a > 1000)
    {
        a = a / 10;
    }
    int b = a % 10;
    System.Console.WriteLine($"Из введеного (положительного) числа: {c}, третья цифра: {b}.");
}
else
{
    if (a < - 99)
    {
         while (a < -1000)
         {
            a = a / 10;
         }
         int b = a % -10;
         System.Console.WriteLine($"Из введенного (отрицательного) числа: {c}, третья цифра: {b}.");
    }
    else 
    {
        System.Console.WriteLine($"Третьей цифры в числе: {a}, нет.");
    }
}
