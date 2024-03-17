// int n = 5;

// int i = 1;
// while(i <= n)
// {
//     System.Console.Write($"{i*i} ");
//     i++;
// }

// n = 10;
// i = 1;
// while(i <= n)
// {
//     System.Console.Write($"{i*i} ");
//     i++;
// }

// n = 15;
// i = 1;
// while(i <= n)
// {
//     System.Console.Write($"{i*i} ");
//     i++;
// }

// //Эта функция заменяем одинаковые действия сверху
// int Square(int value)
// {
//     int result = value * value;
//     return result;
// }

// int Multiply(int value, int value2)
// {
//     int result = value * value2;
//     return result;
// }

// //Если функция возвращаемого значения не имеее, то тип мы указываем void
// void ShowSquare(int value)
// {
//     int result = value * value;
//     System.Console.Write(result);
// }

// //Функция без параметров, без возвращаемого значения, вывод сообщения на экран
// void ShowHelloMessage()
// {
//     System.Console.WriteLine("ello World!"); //побочный эффект - возвращение значения
// }

// //Функция без параметров с возвращаемым значением
// double GetPi()
// {
//     return 3.14159;
// }

// //Функция с параметрами без возвращаемого значения
// void ShowMessage(string message)
// {
//     System.Console.WriteLine(message);
// }

// //Функция с параметрами с возвращаемым значением
// int AddValues(int a, int b)
// {
//     int result = a + b;
//     return result;
// }

//Задача 1.
//Вычислить значение формулы (axb)/(c+d), где
//a,b,c,d - некоторые целые числа. Решение
//оформить в виде функции.

double CalculateFormula(int a, int b, int c, int d)
{
    double numenator = a * b;
    int denumenator = c + d;
    double result = numenator / denumenator;
    return result;
}

double result = CalculateFormula(1, 2, 3, 4);

System.Console.WriteLine(result);