// На основе символов строки (тип string) сформировать массив
// символов (тип char[]). Вывести массив на экран.
// Указание
// Метод строки ToCharArray() не использовать

char[] MyToCharArray(string str)
{
    char[] chars = new char[str.Length];
    for (int i = 0; i < chars.Length; i++)
    {
        chars[i] = str[i];
    }

    return chars;
}

void PrintArray(char[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}

System.Console.Write("Input any string: ");
string str = Console.ReadLine();
PrintArray(MyToCharArray(str));