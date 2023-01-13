using System;
using static System.Console;

Clear();
Write("Введите M: ");
int m = int.Parse(ReadLine());
Write("Введите N: ");
int n = int.Parse(ReadLine());
WriteLine(PrintNumbers(m, n));

int PrintNumbers(int a, int b)
{
    if (b == 0) return 1;
    return (a * PrintNumbers(a, b - 1));
}