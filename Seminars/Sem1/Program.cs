// Console.WriteLine("what is your name?");
// string name = Console.ReadLine();
// System.Console.WriteLine("Hello, " + name + "!");
// System.Console.WriteLine("How old are you?");
// int age = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(age * age);

// Напишите программу, которая на вход
// принимает два целых числа и проверяет,
// является ли первое число квадратом второго.
// a = 25, b = 5 => да
// a = 2, b = 10 => нет
// a = 9, b = -3 => да
// a = -3, b = 9 => нет

// System.Console.Write("input first number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("input second number: ");
// int b = Convert.ToInt32(Console.ReadLine());
// if( b * b == a)
// {
//     System.Console.WriteLine($"{a} is quad of {b}");
// }
// else
// {
//     System.Console.WriteLine($"{a} is not quad of {b}");
// }

// Напишите программу, которая на вход принимает
// целое число N, а на выходе показывает все целые
// числа в промежутке от -N до N.
// Примеры
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2

// System.Console.WriteLine("Input N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int count = -n;
// while (count <= n)
// {
//     System.Console.Write(count + " ");
//     count++;
// }

// Напишите программу, которая принимает на вход
// трёхзначное целое число и на выходе показывает сумму
// первой и последней цифры этого числа.
// 456 => 10
// 782 => 9
// 918 => 17

// System.Console.WriteLine("Input three-digit number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num >= 100 && num <= 999)
// {
//     int ed = num % 10;
//     int sot = num / 100;
//     System.Console.WriteLine($"{num} -> {ed + sot}");
// }
// else
// {
//     System.Console.WriteLine("You input is not three-digit number.");
// }