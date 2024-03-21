// Считать с консоли строку, состоящую из цифр и
// латинских букв. Сформировать массив, состоящий
// из цифр этой строки.

char[] GetDigitsFromStr(string s)
{
    string digits = "";
    foreach (char e in s)
    {
        if(char.IsDigit(e) == true)
        {
            digits = digits + e;
        }
    }
    char[] chars = digits.ToCharArray();
    return chars;
}

void PrintArray(char[] chars)
{
    foreach (char e in chars)
    {
        System.Console.Write($"{e} ");
    }
}

string str = System.Console.ReadLine();
char[] result = GetDigitsFromStr(str);
PrintArray(result);