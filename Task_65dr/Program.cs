//


Console.Write("Задайте число M: ");
int numM = int.Parse(Console.ReadLine());
Console.Write("Задайте число N: ");
int numN = int.Parse(Console.ReadLine());

void PrintNumbersUp(int n, int m)
{
    if (n == (m - 1)) return;
    PrintNumbersUp(m, n - 1);
    Console.Write($"{n} ");
}
void PrintNumbersDown(int m, int n)
{
    if (m == (n - 1)) return;
    PrintNumbersUp(m, n + 1);
    Console.Write($"{n} ");
}
if (numN > numM)
{
    PrintNumbersUp(numM, numN);
}
else
{
    PrintNumbersDown(numM, numN);
}