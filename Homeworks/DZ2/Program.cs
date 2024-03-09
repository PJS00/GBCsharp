// Максимальное из трех чисел

// Внутри класса Answer напишите метод FindMax, который принимает на вход три числа и выдаёт максимальное из этих чисел.

int a = 1;
int b = 57;
int c = 14;

int[] arrNumbers = {a, b, c};

int max = arrNumbers[0];
int count = 0;
while (count < arrNumbers.Length)
{
    if (arrNumbers[count] > max) 
    {
        max = arrNumbers[count];
    }
    count++;
}

// в автотесте писала return max; вместо следующей строки.
System.Console.WriteLine(max);