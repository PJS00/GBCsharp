int n = 10;
int[] arr = new int[n];

void FillArray(int[] arr)
{
    int i = 0;
    while (i < arr.Length)
    {
        arr[i] = i + 1;
        i++;
    }
}


void PrintArray(int[] arr)
{
    foreach (int e in arr)
    {
        System.Console.Write($"{e} ");
    }
}

int GetSumOfElements(int[] arr)
{
    int sum = 0;
    foreach (int e in arr)
    {
        sum = sum + e;
    }
    return sum;
}

int GetProductfElements(int[] arr)
{
    int product = 1;
    foreach (int e in arr)
    {
        product = product * e;
    }
    return product;
}

int[] array = { 1, 2, 3, 4, 5 };
FillArray(array);
PrintArray(array);
System.Console.WriteLine();
int sum = GetSumOfElements(array);
int product = GetProductfElements(array);
System.Console.WriteLine(sum);
System.Console.WriteLine(product);