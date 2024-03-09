// Большее из двух чисел
// Внутри класса Answer напишите метод CompareNumbers, который на вход принимает два числа и выводит, какое число большее, а какое меньшее.
// Пример использования:
// На входе:
// firstNumber: '5'
// secondNumber: '6'
// На выходе:
// второе число больше

// На входе:
// firstNumber: '6'
// secondNumber: '3'
// На выходе:
// первое число больше

// На входе:
// firstNumber: '3'
// secondNumber: '3'
// На выходе:
// числа равны

System.Console.WriteLine("Input firstNumber: ");
System.Console.WriteLine("Input secondNumber: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber == secondNumber)
{
    System.Console.WriteLine("Числа равны");
}
else
{
    if (firstNumber > secondNumber)
    {
        System.Console.WriteLine("Первое число больше");
    }
    else
    {
        System.Console.WriteLine("Второе число больше");
    }
}