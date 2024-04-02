// Задача 2: Напишите программу вычисления функции Аккермана
// с помощью рекурсии. Даны два неотрицательных числа m и n.

int Promt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int AckermanFunction(int M, int N)
{
    if (M == 0) return N + 1;
    else if (M > 0 && N == 0) return AckermanFunction(M - 1, 1);
    else if (M > 0 && N > 0) return AckermanFunction(M - 1, AckermanFunction(M, N - 1));
    return 0;
}

int M = Promt("Введите неотрицательное число M > ");
int N = Promt("Введите неотрицательное число N > ");

if (M < 0 || N < 0)
{
    Console.WriteLine("Введите неотрицательные числа!!!");
}
else
{
    Console.WriteLine($"Значение функции Аккермана - А({M}, {N}) равно: {AckermanFunction(M, N)}");
}
