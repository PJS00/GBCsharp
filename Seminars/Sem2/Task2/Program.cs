// Напишите программу, которая принимает на вход
// трёхзначное число и возводит вторую цифру этого
// числа в степень, равную третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1

// System.Console.WriteLine("Введи трёхзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number >= 100 && number <= 999)
// {
//     int baseNumber = number % 100) / 10;
//     int exponent = number % 10;
//     double result = Convert.ToDouble(Math.Pow(baseNumber, exponent));
//     System.Console.WriteLine(result);
// }
// else
// {
//     System.Console.WriteLine("You input is not three-digit number.");
// }


int SecondToThird(int number)
{
    int dec = number / 10 % 10;
    int ed = number % 10;
    // или это вместо цикл for
    // int res = (int)Math.Pow(dec,ed);
    // return res;
    int result = 1;
    for (int i = 0; i < ed; i++)
    {
        result = result * dec;
    }
    return result;
}

bool IsThreeDigit(int number)
{
    if (number >= 100 && number <= 999)
    {
        return true;
    }
    else
    {
        return false;
    }
}

System.Console.WriteLine("Введи трёхзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());

int result = SecondToThird(a);
System.Console.WriteLine(result);

