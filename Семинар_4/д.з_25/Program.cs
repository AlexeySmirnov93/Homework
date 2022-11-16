//Напишите программу, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 
//Для решения задания использование цикла for является обязательным условием.
//Не использовать встроенный метод возведения в степень.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int GetExponentiation(int a, int b)
{
   int degree = 1;

   for(int i = 1; i <= b; i++)
   {
     degree = degree * a;
   }
   return degree;

}

Console.WriteLine("Введите возводимое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень: ");
int b = Convert.ToInt32(Console.ReadLine());
int degree = GetExponentiation(a,b);
System.Console.WriteLine($"Чило {a} в степени {b} = {degree}");
