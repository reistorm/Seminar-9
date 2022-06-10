// Напишите программу, которая будет принимать 
// на вход число и возвращать сумму его цифр.

Console.Write("Задайте число: ");
int num = int.Parse(Console.ReadLine());

int GetNumberSum(int n)
{
    int sum = 0;
    if(n == 0) return 0;
    sum = n % 10 + GetNumberSum(n/10);
    return sum;
}

Console.WriteLine(GetNumberSum(num));