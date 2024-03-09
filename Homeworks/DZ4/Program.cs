// Внутри класса Answer напишите метод PrintEvenNumbers, которая на вход принимает число (number), а на выходе выводит все чётные числа от 1 до number (включительно), после каждого числа должен быть знак пробела.

// На входе:
// number = 5 
// На выходе:
// 2 4 

// На входе:
// number = 8 
// На выходе:
// 2 4 6 8 

Console.WriteLine("Введите число N: ");
int number = int.Parse(Console.ReadLine());

int count = 2;

while (count < number + 1)
{
    if (count % 2 == 0)
    {
        Console.Write(count + " ");
        count = count + 2;
    }
}

//это не писала в автотесте
if (number == 0 || number == 1) Console.WriteLine($"Для числа N = {number} нет четных чисел в диапазоне от 1 до N");