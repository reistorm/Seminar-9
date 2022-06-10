// Напишите программу, которая на вход принимает 
// два числа A и B, и возводит число А в 
//целую степень B с помощью рекурсии

Console.Write("Задайте число A: ");
int numA = int.Parse(Console.ReadLine());
Console.Write("Задайте число B: ");
int numB = int.Parse(Console.ReadLine());

int FondPow(int a, int b)
{
    if (b == 0) return 1;
    a = a * FondPow(a, b - 1);
    return a;
}
Console.WriteLine(FondPow(numA, numB));