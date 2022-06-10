// Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа 
// в промежутке от 1 до N.


Console.Write("Задайте число: ");
int number = int.Parse(Console.ReadLine());

// void NaturalNumber(int num)
// {
//     if(num == 1) return;
//     num--;
//     NaturalNumber(num);
//     Console.Write($"{num} ");

// }
// NaturalNumber(number + 1);

void NaturalNumber(int num)
{
    if(num == 0) return;
    NaturalNumber(num - 1);
    Console.Write($"{num} ");

}
NaturalNumber(number);