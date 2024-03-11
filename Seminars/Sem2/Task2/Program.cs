// Напишите программу, которая принимает на вход
// трёхзначное число и возводит вторую цифру этого
// числа в степень, равную третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1

System.Console.WriteLine("Введи трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100 && number <= 999)
{
    int baseNumber = (number % 100) / 10;
    int exponent = number % 10;
    double result = Convert.ToDouble(Math.Pow(baseNumber, exponent));
    System.Console.WriteLine(result);
}
else
{
    System.Console.WriteLine("You input is not three-digit number.");
}




// for (int i = 0; i < exponent; i++) {
//     result *= baseNumber;
// }

// Console.WriteLine(result);