// Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.

int SumOfDigits(int a) //456 -> 15
{
    if(a > 0)
    {
        return SumOfDigits(a / 10) + a % 10;
    }
    return 0;
}

System.Console.WriteLine(SumOfDigits(456));