// Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

using static System.Console;

Write("Введите число N: ");
int numN = int.Parse(Console.ReadLine()!);
int sumNumber = SumNumber(numN);
WriteLine($"Сумма цифр в числе:{numN} составляет {sumNumber}");

//метод функции чисел
int SumNumber(int numberN)
{

    int counter = Convert.ToString(numberN).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
        advance = numberN - numberN % 10;
        result = result + (numberN - advance);
        numberN = numberN / 10;
    }
    return result;
}