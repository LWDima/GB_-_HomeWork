//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

using static System.Console;

Clear();
Write("Введите первое число ");
int num1 = Convert.ToInt32(ReadLine());
Write("Введите второе число число ");
int num2 = Convert.ToInt32(ReadLine());



if (num1 > num2)
{
    Write($"Первое число {num1} больше чем второе {num2}");
}
if (num2 > num1)
{
    Write($"Второе число {num2} больше чем первое {num1}");
}
if (num2 == num1)
{
    Write("Числа равны");
}