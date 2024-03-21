// Задайте двумерный массив. Найдите элементы,
// у которых оба индекса чётные, и замените
// эти элементы на их квадраты.

int[,] CreateMatrix(int rows, int columns, int min, int max)
{
    Random rand = new Random();
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rand.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

int[,] EvenIndToSquare(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i = i + 2)
    {
        for (int j = 0; j < matrix.GetLength(1);j = j + 2)
        {
            //if(i % 2 == 0 && j % 2 == 0)
            //{
                matrix[i,j] =  matrix[i,j] *  matrix[i,j];
            //}
        }
    }
    return matrix;
}

System.Console.Write("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input minimal value: ");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Input maximal value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] matrix = CreateMatrix(rows, columns, min, max);
PrintMatrix(matrix);
System.Console.WriteLine();
PrintMatrix(EvenIndToSquare(matrix));