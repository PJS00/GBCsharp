// Задайте массив символов (тип char []). Создайте строку из
// символов этого массива.
// Указание
// Конструктор строки вида string(char []) не использовать.

// char[] chars = { 'w', 'o', 'r', 'l', 'd' };
// string result = new string(chars);
// System.Console.WriteLine(result);

string CharsArrToString(char[] chars)
{
    // string result = string.Empty();
    string result = "";

    for (int i = 0; i < chars.Length; i++)
    {
        result = result + chars[i];
    }
    return result;
}

char[] InputCharArr(int n)
{
    char[] chars = new char[n];
    for (int i = 0; i < chars.Length; i++)
    {
        System.Console.Write($"input chrcter number {i + 1} : ");
       chars[i] = Convert.ToChar(Console.ReadLine());
    }
    return chars;
}

char[] chars = InputCharArr(10);
string res = CharsArrToString(chars);
System.Console.WriteLine(res);