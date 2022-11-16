//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 
//Для решения задания использование цикла for является обязательным условием
//452 -> 11
//82 -> 10
//9012 -> 12

int  GetSumOfDigits(int a)
{   
    int result = 0;

    for(int i = 0; i < a;)
    {
        result = result + a % 10;
        a = a / 10;
    }
    return result;
}

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int result =  GetSumOfDigits(a);
System.Console.WriteLine($"Сумма цифр числа {a} = {result}");