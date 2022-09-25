// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

using static System.Console;

Clear();
Write("Введите трехзначное число: ");
int num = Convert.ToInt32(ReadLine());

if (num < 100 || num > 999)
{
    WriteLine("Вы ввели не трехзначное число");
}
else
{
    int result = num / 10 % 10;
    WriteLine($" Второе чило трехзначного чисал {result}");
}


