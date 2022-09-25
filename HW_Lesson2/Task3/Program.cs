// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.

using static System.Console;

Clear();
WriteLine("Введите число означающее день недели");
int num = Convert.ToInt32(ReadLine()!);

if (num >= 1 && num <= 7)
{
    if (num == 6 | num == 7) WriteLine("Сегодня выходной");
    else WriteLine("Сегодня Рабочий день");
}
else
{
    WriteLine("Такого дня недели нету");
}


