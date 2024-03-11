// Напишите программу, которая принимает на
// вход трёхзначное число и удаляет вторую
// цифру этого числа.
// Примеры
// a = 256 => 26
// a = 891 => 81

// System.Console.WriteLine("Введи трёхзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int delete = 1;
// var str = number.ToString();
// number = int.Parse(str.Remove(delete, 1));
// int result = Convert.ToInt32(number);
// System.Console.WriteLine(result);


void MinusSecond(int num)
{
    int ed = num % 10;
    int sot = num / 100;
    System.Console.WriteLine($"{num} -> {sot * 10 + ed}");
}

System.Console.WriteLine("Введи трёхзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());

MinusSecond (a);

// System.Console.WriteLine("Введи трёхзначное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int MinusSecond(int num)
// {
//     int ed = num % 10;
//     int sot = num / 100;
//     int result = sot * 10 + ed;
//     return result;
// }

// System.Console.WriteLine("Введи трёхзначное число: ");
// int a = Convert.ToInt32(Console.ReadLine());

// int res = MinusSecondInt(a);
// System.Console.WriteLine(res);