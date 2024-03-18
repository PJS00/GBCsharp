// Задайте одномерный массив, заполненный случайными
// числами. Определите количество простых чисел в этом
// массиве.

// int[] CreateArray(int n, int min, int max)
// {
//     int[] array = new int[n];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
//     System.Console.WriteLine();
// }

// int SimpleNumbersCount(int[] arr)
// {
//     int countNum = 0;
//     foreach (int item in arr)
//     {
//         int count = 0;
//         for (int i = 2; i <= item; i++)
//         {
//             if(item % i == 0)
//             {
//                 count++;
//             }
//         }
//         if(count == 1) 
//         {
//             countNum++;
//         }
//     }
//     return countNum;
// }

// System.Console.Write("Input size of array: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input minimal value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input maximal value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] arr = CreateArray(size, min, max);
// PrintArray(arr);
// System.Console.WriteLine(SimpleNumbersCount(arr));

// Задайте массив из N случайных целых чисел (N вводится с
// клавиатуры).
// Найдите количество чисел, которые оканчиваются на 1 и
// делятся нацело на 7.

// int[] CreateArray(int n, int min, int max)
// {
//     int[] array = new int[n];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
//     System.Console.WriteLine();
// }

// int FindNum(int[] arr)
// {
//     int count = 0;
//     foreach (int item in arr)
//     {
//         if(item % 10 == 1 && item % 7 == 0)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// System.Console.Write("Input size of array: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input minimal value: ");
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input maximal value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] arr = CreateArray(size, min, max);
// PrintArray(arr);
// System.Console.WriteLine(FindNum(arr));

// Заполните массив на N (вводится с консоли, не более 8)
// случайных целых чисел от 0 до 9.
// Сформируйте целое число, которое будет состоять из цифр из
// массива. Старший разряд числа находится на 0-м индексе,
// младший – на последнем.

// Ввод значений с консоли
// string input = Console.ReadLine();
// int value = Convert.ToInt32(input);

// Генерация случайных чисел
// Random rnd = new Random();
// int value = rnd.Next(1,10);

int[] CreateArray(int n, int min, int max)
{
    int[] array = new int[n];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}

int ArrayToNumber(int[] array)
{
    int result = 0;
    int count = 0;
    for (int i = array.Length - 1; i >= 0; i--)
    {
        result = result + array[i] * (int)Math.Pow(10, count++);
    }
    return result;
}

System.Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input minimal value: ");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input maximal value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArray(size, min, max);
PrintArray(arr);
System.Console.WriteLine(ArrayToNumber(arr));