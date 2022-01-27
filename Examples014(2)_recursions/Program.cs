// вывести строку с числами от a до b, a>=b

string NumbersFor(int a, int b)
{
    string result = String.Empty;
    for (int i = b; i >= a; i--)
    {
        result += $"{i}";
    }
    return result;
}

// void PrintNumbersFor (string numbers)
// {
//     for (int i = 0; i<numbers.Length; i++)
//     {
//         Console.Write (numbers[i]);
//     }
// }

// string resultOfNumbersFor = NumbersFor (10,1);
// PrintNumbersFor (resultOfNumbersFor);

Console.WriteLine (NumbersFor(1,10));
Console.WriteLine ("Цикл на уменьшение");


string NumbersRec(int a, int b)
{
    if (a <= b) return NumbersRec(a + 1, b) + $"{a}";
    else return String.Empty;

}

Console.WriteLine(NumbersRec(1, 10));
Console.WriteLine ("Цикл на уменьшение с рекурсией");
