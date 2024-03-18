//Вывод на экран квадратов чисел от 1 до N.
// int n = 5;

// int i = 1;
// while(i <= n)
// {
//     System.Console.Write($"{i*i} ");
//     i++;
// }

void PrintSquares(int limit)
{
    int i = 1;
    while (i <= limit)
    {
        System.Console.Write($"{i * i} ");
        i++;
    }
}

PrintSquares(5);
PrintSquares(10);
PrintSquares(15);