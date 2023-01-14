using System;
using static System.Console;

Clear();
Write("Введите N: ");
int n=int.Parse(ReadLine());
WriteLine(PrintNumbers(n));
int PrintNumbers(int sum)
{
    if (sum == 0)
        return 0;
    return (sum % 10 + PrintNumbers(sum / 10));
}