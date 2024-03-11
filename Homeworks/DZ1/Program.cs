// Задача 1
// Большее из двух чисел
// Внутри класса Answer напишите метод CompareNumbers, который на вход принимает два числа и выводит, какое число большее, а какое меньшее.
// Пример использования:
// На входе:
// firstNumber: '5'
// secondNumber: '6'
// На выходе:
// второе число больше

// На входе:
// firstNumber: '6'
// secondNumber: '3'
// На выходе:
// первое число больше

// На входе:
// firstNumber: '3'
// secondNumber: '3'
// На выходе:
// числа равны

// System.Console.WriteLine("Input firstNumber: ");
// System.Console.WriteLine("Input secondNumber: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());
// int secondNumber = Convert.ToInt32(Console.ReadLine());

// if (firstNumber == secondNumber)
// {
//     System.Console.WriteLine("Числа равны");
// }
// else
// {
//     if (firstNumber > secondNumber)
//     {
//         System.Console.WriteLine("Первое число больше");
//     }
//     else
//     {
//         System.Console.WriteLine("Второе число больше");
//     }
// }





// Задача 2
// Максимальное из трех чисел
// Внутри класса Answer напишите метод FindMax, который принимает на вход три числа и выдаёт максимальное из этих чисел.

// int a = 1;
// int b = 57;
// int c = 14;

// int[] arrNumbers = {a, b, c};

// int max = arrNumbers[0];
// int count = 0;
// while (count < arrNumbers.Length)
// {
//     if (arrNumbers[count] > max) 
//     {
//         max = arrNumbers[count];
//     }
//     count++;
// }

// // в автотесте писала return max; вместо следующей строки.
// System.Console.WriteLine(max);





// Задача 3
// Внутри класса Answer напишите метод CheckIfEven, который на вход принимает число number и выводит, является ли число чётным (делится ли оно на два без остатка).
// Пример использования:
// На входе:
// number: '6'
// На выходе:
// четное

// На входе:
// number: '3'
// На выходе:
// нечетное

// Console.WriteLine("Введите целое число: ");
// // double n = Convert.ToDouble(Console.ReadLine());
// int number = int.Parse(Console.ReadLine());
// if (number % 2 == 0) 
// {
//     //в автотесте в скобках писала просто "четное"
//     Console.WriteLine($"Число {number} является чётным");
// }
// else
// {
//     //в автотесте в скобках писала просто "нечетное"
//     Console.WriteLine($"Число {number} не является чётным");
// }





// Задача 4
// Внутри класса Answer напишите метод PrintEvenNumbers, которая на вход принимает число (number), а на выходе выводит все чётные числа от 1 до number (включительно), после каждого числа должен быть знак пробела.

// На входе:
// number = 5 
// На выходе:
// 2 4 

// На входе:
// number = 8 
// На выходе:
// 2 4 6 8 

// Console.WriteLine("Введите число N: ");
// int number = int.Parse(Console.ReadLine());

// int count = 2;

// while (count < number + 1)
// {
//     if (count % 2 == 0)
//     {
//         Console.Write(count + " ");
//         count = count + 2;
//     }
// }

// //это не писала в автотесте
// if (number == 0 || number == 1) Console.WriteLine($"Для числа N = {number} нет четных чисел в диапазоне от 1 до N");