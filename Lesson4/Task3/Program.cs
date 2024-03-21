// Строка в C# - массив символов типа char
// Для работы со строками используем специальный тип string.

// string str = "Hello World!";
// System.Console.Write(str[0]); //str[0] - первый символ строки
// Строки не могут быть инменены.
// Размер существующей строки не может быть изменен (удлиннен или укорочен)

// Создание строк
// string s1 = "Hello1";

// char[] ch_array = { 'w', 'o', 'r', 'l', 'd' };
// string s2 = new String(ch_array); //первый string - тип данных, второй String - метод

// string s3 = new String('a', 6); //результатом будет строка "аааааа"

// Методы
// Contains содержит ли строка образец
// EndWith оканчивается ли строка каким-либо словом, проверяется расширение файла
// Index01 находит индекс первого вхождения символа в строке
// Insert вставляет слово на опледеленное место в строке, создает новую строку
// Replace заменяет слово на какую-либо подстроку, удаляем слово = меняем его на пробел, создает новую строку

// Задача 3
// Считать с консоли строку. состоящую из цифр и латинских букв.
// Сформировать новую строку, состоящую из букв исходной строки.

string GetLettersFromStr(string s)
{
    string letters = "";
    foreach (char e in s)
    {
        if(char.IsASCiiLetter(e) == true)
        {
            letters = letters + e;
        }
        return letters;
    }
}

string str = System.Console.ReadLine();
string result = GetLettersFromStr(str);
System.Console.WriteLine(result);