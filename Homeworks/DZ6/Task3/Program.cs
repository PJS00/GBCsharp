// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.


// bool IsPalindrom(string Str, bool ignoreCase = true)
// {
//     if (ignoreCase)
//     {
//         Str = Str.ToLowerInvariant();
//     }

//     var inputArray = Str.ToArray();
//     var reversedArray = inputArray.Reverse().ToArray();

//     return inputArray.SequenceEqual(reversedArray);
// }

// bool IsPalindrom(string Str, bool ignoreCase = true)
// {
//     var reversedStr = new string(Str.Reverse().ToArray());
//     bool result;
//     if (ignoreCase)
//     {
//         result = reversedStr.Equals(Str, StringComparison.InvariantCultureIgnoreCase);
//     }
//     else
//     {
//         result = reversedStr.Equals(Str);
//     }

//     return result;
// }

// Console.WriteLine("Inpute string: ");
// string Str = Console.ReadLine();


string Reverser(string a)
{
    char[] arr = a.ToCharArray();
    Array.Reverse(arr);
    return new string(arr);
}
string Palindromer(string x)
{
    string y = Reverser(x);
    Console.WriteLine(y);
    if (Equals(x, y))
        return "Палиндром";
    else
        return "Не палиндром";
}


Console.WriteLine("Введите тестируемую строку");
string input = Console.ReadLine();
string str = input.ToLower();
Console.WriteLine(input + " - " + Palindromer(str));
Console.WriteLine();
