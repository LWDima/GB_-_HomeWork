//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

using static System.Console;

Clear();
Write("Введите первое число ");
int num1 = Convert.ToInt32(ReadLine());
Write("Введите второе число число ");
int num2 = Convert.ToInt32(ReadLine());
Write("Введите третье число ");
int num3 = Convert.ToInt32(ReadLine());

int max = num1;

if (num2 > max)
{
    max = num2;
}
if (num3 > max)
{
    max = num3;
}

Write($"Максимальное число {max}");