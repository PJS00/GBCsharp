// Количество элементов массива на отрезке

// Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [10,90].
// Начальные условия:
// int[] array = {1, 5, 10, 20, 30, 40, 99, 4, 90, 3}; // Создание массива
// Выводится: 5

// Подсчет количества элементов массива, попадающих в заданный диапазон
// numbers - массив, в котором ведется подсчет
// minRange - минимальная граница диапазона
// maxRange - максимальная граница диапазона
// public static int CountItemsRange(int[] numbers, int minRange, int maxRange)

// int[] CreateArray(int n, int minRange, int maxRange)
// {
//     int[] numbers = new int[n];
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         numbers[i] = new Random().Next(minRange, maxRange + 1);
//     }
//     return numbers;
// }
    
// void PrintArray(int[] numbers)
// {
//    for (int i = 0; i < numbers.Length; i++)
//     {
//         System.Console.Write(numbers[i] + " ");
//     } 
// }

// //нахождение чисел в массиве, которые лежат в диапазоне от 10 до 90
// int FindNumber(int[] numbers)
// {
//     int count = 0;
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         if (numbers[i] > 10 && numbers[i] < 90)
//         {
//             count++;
//         }
//     }
//     return count;
// }



// System.Console.WriteLine("Введи размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введи минимальное число: ");
// int min = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введи максимальное число: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] arr = CreateArray(size, min, max);
// PrintArray(arr);
// System.Console.WriteLine();
// System.Console.WriteLine(FindNumber(arr));

using System;
using System.Linq;

//Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
class UserInputToCompileForTest
{ 
    // Подсчет количества элементов массива, попадающих в заданный диапазон
    // numbers - массив, в котором ведется подсчет
    // minRange - минимальная граница диапазона
    // maxRange - максимальная граница диапазона
    public static int CountItemsRange(int[] numbers, int minRange, int maxRange)
    {
         //Введите сюда свое решение
      int count = 0;
      for (int i = 0; i < numbers.Length; i++)
      {
          if (numbers[i] >= minRange && numbers[i] <= maxRange)
          {
              count++;
          }
      }
      return count;
    }
    
    public static void PrintResult(int[] array)
    {
          //Введите сюда свое решение
      System.Console.WriteLine(CountItemsRange(array, 10, 90));
    }

}


//Не удаляйте и не меняйте класс Answer!
class Answer
{
    public static void Main(string[] args)
    {
        int[] array;
        

        if (args.Length >= 1) {
            // Объединяем все аргументы командной строки в одну строку
            string joinedArgs = string.Join(" ", args);

            // Разделяем строку по запятой с пробелом и преобразуем в массив целых чисел
            array = joinedArgs.Split(", ")
                                  .Select(int.Parse)
                                  .ToArray();
            
            // Теперь arr содержит преобразованные в целые числа из командной строки
        
        } else {
           // Если аргументов на входе нет
            array = new int[] {1, 5, 10, 20, 30, 40, 99, 4, 90, 3}; // Создание массива
        }
        UserInputToCompileForTest.PrintResult(array);
    }
}