// Задача 64: Задайте значения N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// N = 5. -> "5, 4, 3, 2, 1"
// N = 8. -> "8, 7, 6, 5, 4, 3, 2, 1"

using static System.Console;
Clear();
Write("Введите число: ");
int number = int.Parse(ReadLine()!);
int count = 1;
numsN(number, count);


void numsN(int n, int count)
{
    if (count > n)
    {
        return;
    }
    else
    {
        numsN(n, count + 1);
        Write(count + " ");
    }
}