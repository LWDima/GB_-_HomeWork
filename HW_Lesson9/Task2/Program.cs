// // Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
//сумму натуральных элементов в промежутке от M до N.
// // M = 1; N = 15 -> 120
// // M = 4; N = 8. -> 30

using static System.Console;
Clear();
Write("Введите число M: ");
int m = int.Parse(ReadLine()!);

Write("Введите число N: ");
int n = int.Parse(ReadLine()!);

SumFromMToN(m, n);

// вызов функции "сумма чисел от M до N"
void SumFromMToN(int m, int n)
{
    Write(SumMN(m - 1, n));
}

// функция сумма чисел от M до N
int SumMN(int m, int n)
{
    int res = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        res = m + SumMN(m, n);
        return res;
    }
}