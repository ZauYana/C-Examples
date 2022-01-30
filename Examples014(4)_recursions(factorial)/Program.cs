// Factorial

int FactorialFor(int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= i;
    return result;
}

int resultFactorialFor = FactorialFor(5);
Console.WriteLine(resultFactorialFor);
Console.WriteLine ();


int FactorialRec(int n)
{
    if (n == 1) return 1;
    if (n == 0) return 1;
    else return n*FactorialRec(n-1);
}

int resultFactorialRec = FactorialRec(5);
Console.WriteLine(resultFactorialRec);
Console.WriteLine ();