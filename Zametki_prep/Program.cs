// Напишите программу, которая будет принимать 
// на вход число и возвращать сумму его цифр.

// Console.Write("Задайте число: ");
// int n = int.Parse(Console.ReadLine());
// Console.WriteLine("Сумма цифр числа равна: "+ Summa(n));
// int Summa(int n)
// {
//    if (n > 0) return n % 10 + Summa(n / 10);
//    return 0;
// }

// Напишите программу, которая на вход принимает 
// два числа A и B, и возводит число А в 
//целую степень B с помощью рекурсии

Console.Write("Задайте число A: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Задайте число B: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine($"\n{a} в степени {b} равно: {Pow(a, b)}\n");

static int Pow(int a, int pow)
{
    return pow == 0 ? 1 : Pow(a, pow - 1) * a;
}