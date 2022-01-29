// сумма чисел от 1 до n 


int SumFor(int n)
{
    int result = 0;
    for (int i = 1; i <= n; i++) result += i;
    return result;
}

int resultSumFor = SumFor(10);
Console.WriteLine(resultSumFor);
Console.WriteLine ("метод через for");
Console.WriteLine();

int SumRec(int n)
{
    if (n == 0) return 0;
    else return n + SumRec(n-1);
}

int resultSumRec = SumRec (10);
Console.WriteLine (resultSumRec);
Console.WriteLine ("метод через recursion");
