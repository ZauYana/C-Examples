//вычислить a в степени n

int PowerFor(int a, int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= a;
    return result;
}




int PowerRec(int a, int n)
{
    return n == 0 ? 1 : PowerRec(a, n - 1) * a;
}

int PowerRecMatch(int a, int n)
{
    if (n == 0) return 1;
    else if (n % 2 == 0) return PowerRecMatch(a * a, n / 2);
    else return PowerRecMatch(a, n - 1) * a;
}



int resultPowerFor = PowerFor(2, 10);
Console.WriteLine(resultPowerFor);

int resultPowerRec = PowerRec(2, 10);
Console.WriteLine(resultPowerRec);

int resultPowerRecMatch = PowerRecMatch(2, 10);
Console.WriteLine(resultPowerRecMatch);
