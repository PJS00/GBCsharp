// Считать строку с консоли, состоящую из латинских
// букв в нижнем регистре. Выяснить, сколько среди
// введённых букв гласных.
// Пример
// “hello” => 2
// “world” => 1


int CountCharString(string str)
{
    char[] chars = {'a', 'e', 'y', 'u', 'i', 'o'};
    int count = 0;
    for (int i = 0; i < chars.Length; i++)
    {
        foreach (char item in str)
        {
            if (item == chars[i])
            {
                count++;
            }
        }
    }
    return count;
}

Console.WriteLine ("Inpute strng: ");
string str = Console.ReadLine();
Console.WriteLine (CountCharString(str));
