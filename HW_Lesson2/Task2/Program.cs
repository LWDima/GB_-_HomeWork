// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

using static System.Console;

Clear();
Write("Введите трехзначное число: ");
int num = Convert.ToInt32(ReadLine());

if (num < 100)
{
    WriteLine("Третьей цифры нет");
}
else
{
    int result = num / 100 % 10;
    WriteLine($" третья цифра числа {result}");
}