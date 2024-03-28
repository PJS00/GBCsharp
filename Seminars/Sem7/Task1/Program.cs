void F(int a)
{
    if(a >= 1)
    {
        F(a - 1);
    }
    System.Console.Write(a + " ");
}

F(5);