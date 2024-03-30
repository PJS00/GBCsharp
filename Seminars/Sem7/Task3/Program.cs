// Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в
// промежутке от M до N.

// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 5, 6, 7, 8"

// int n = Convert.ToInt32(Console.ReadLine());
// int m = Convert.ToInt32(Console.ReadLine());
// void F(int m, int n)
// {
//   if (m != n)
//   {
//     if (m > n)
//     {
//       F(m - 1, n);
//       System.Console.Write(m + " ");
//     }
//     else
//     {

//       F(m + 1, n);
//       System.Console.Write(m + " ");

//     }

//   }
//   else
//   {
//     System.Console.Write(m + " ");
//   }
// }

void Fact(int m, int n)
{
  if (m > n)
  {
    Fact(n, m);
  }
  if (m == n)
  {
    System.Console.WriteLine(m);
    return;
  }
  System.Console.WriteLine(m + " ");
  Fact(m + 1, n);
}
Fact(8, 5);