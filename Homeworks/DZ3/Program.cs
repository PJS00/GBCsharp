// Внутри класса Answer напишите метод CheckIfEven, который на вход принимает число number и выводит, является ли число чётным (делится ли оно на два без остатка).
// Пример использования:
// На входе:
// number: '6'
// На выходе:
// четное

// На входе:
// number: '3'
// На выходе:
// нечетное

Console.WriteLine("Введите целое число: ");
// double n = Convert.ToDouble(Console.ReadLine());
int number = int.Parse(Console.ReadLine());
if (number % 2 == 0) 
{
    //в автотесте в скобках писала просто "четное"
    Console.WriteLine($"Число {number} является чётным");
}
else
{
    //в автотесте в скобках писала просто "нечетное"
    Console.WriteLine($"Число {number} не является чётным");
}