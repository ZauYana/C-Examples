//  собрать строку с числами от a до b, a<= b

string NumbersFor(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i <= b; i++)
    {
        result += $"{i}";
    }
    return result;
}

Console.WriteLine (NumbersFor(2,10));
Console.WriteLine ("Вывод без рекурсии");

string NumbersRec (int a, int b)
{
    if (a<=b) return $"{a}" + NumbersRec (a+1,b);
    else return String.Empty;
}
Console.WriteLine (NumbersRec(2,10));
Console.WriteLine ("Вывод c рекурсией");

string NumbersRec1 (int a, int b)
{
    if (a<b) return $"{a}" + NumbersRec1 (a+1,b);
    else return $"{b}";
}
Console.WriteLine (NumbersRec1(2,10));
Console.WriteLine ("Вывод c рекурсией, на одну рекурсию меньше");

