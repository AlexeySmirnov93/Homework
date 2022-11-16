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
int a = Convert.ToInt32(Console.ReadLine());
if (a > 9999 && a < 100000)
{
 bool revers = PolydromeСheck(a);
 if (revers == true) System.Console.WriteLine("полиндром");
 else System.Console.WriteLine("не полиндром");
}
 else System.Console.WriteLine("Не пятизначное число!");