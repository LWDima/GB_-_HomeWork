// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212->нет
//12821->да

using static System.Console;

Clear();
WriteLine("Введите пятизначное число: ");
string num = ReadLine();
int len = num.Length;

if (len == 5)
{
    if (num[0] == num[4] && num[1] == num[3])
    {
        Write($"Число {num} является палиндромом");
    }
    else
    {
        Write($"Число {num} не является палиндромом");
    }
}
else
{
    Write($"Число {num} не пятизначное");
}