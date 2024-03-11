// Напишите программу, которая принимает на
// вход трёхзначное число и удаляет вторую
// цифру этого числа.
// Примеры
// a = 256 => 26
// a = 891 => 81

System.Console.WriteLine("Введи трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int delete = 1;
var str = number.ToString();
number = int.Parse(str.Remove(delete, 1));
int result = Convert.ToInt32(number);
System.Console.WriteLine(result);
