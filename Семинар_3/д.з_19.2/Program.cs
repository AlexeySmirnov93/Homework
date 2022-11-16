// Напишите программу, которая принимает на вход пятизначное число и проверяет,
//является ли оно палиндромом.
bool PolydromeСheck(int a)
{   
    
    int b = (a % 10000) / 1000;
    int c = (a % 100000) / 10000;
    int revers = (a / 100) * 100 + b * 10 + c;
    
    
    if (revers == a)
    {
       return true;
    }
    else
    {
       return false;
    }
    
    
} 

Console.WriteLine("Введите пятизначное число: ");
string str;
if (int.TryParse(str = Console.ReadLine()!, out int a) == true) // Проверка на integer,введено ли число
{
 a = Convert.ToInt32(str);
    if (a >= 0)
    {
        if (a > 9999 && a < 100000 )
        {
            bool revers = PolydromeСheck(a);
            if (revers == true) System.Console.WriteLine("Полиндром");
            else System.Console.WriteLine("Не полиндром");
        }
    
        else System.Console.WriteLine("Не пятизначное число!");
    }
    else System.Console.WriteLine("Палиндромы, не являются отрицательными числами");

}
else System.Console.WriteLine("Не integer");
