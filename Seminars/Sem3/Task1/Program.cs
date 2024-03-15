// int[] GenerateArray(int length, int min, int max)
// {
//     int[] array = new int[length];
//     for (int i = 0; i < length; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }

// System.Console.WriteLine("Введите длину массива: ");
// int[] array = GenerateArray(int.Parse(Console.ReadLine()), 100, 1000);
// PrintArray(array);

// Задание 1. Совместная работа
// Семинар 3. Массивы
// 15 мин
// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве. Программа
// должна выдать ответ: Да/Нет.
// Примеры
// [1 3 4 19 3], 8 => Нет
// [-4 3 4 1], 3 => Да

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
}

//нахождение числа в массиве
bool FindNumber(int num, int[] array)
{
    foreach (int item in array)
    {
        if(item == num)
        {
            return true;
        }
    }
    return false;
}



System.Console.WriteLine("Введи размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введи минимальное число: ");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введи максимальное число: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArray(size, min, max);
PrintArray(arr);
System.Console.WriteLine();
System.Console.WriteLine("Введите число, которое хотите найти: ");
int num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(FindNumber(num, arr));