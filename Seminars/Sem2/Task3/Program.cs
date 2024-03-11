// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если первое число некратно
// второму, то программа выводит остаток от деления.
// Примеры
// 14, 5 => нет, 4
// 16, 8 => да
// 4, 3 => нет, 1

void FirstDivSecond(int a, int b)
{
    if (a % b == 0)
    {
        System.Console.WriteLine($"{a} кратно {b}");
    }
    else
    {
        System.Console.WriteLine($"{a} не кратно {b}, остаток {a % b}");
    }
}

System.Console.WriteLine("Введи первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введи второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

FirstDivSecond(num1, num2);