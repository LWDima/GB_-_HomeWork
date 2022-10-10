// Напишите метод, который принимает на вход два числа (A и B) и возводит число A 
//в натуральную степень B с использованием цикла.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
using static System.Console;

Clear();
Write("введите число A: ");
int numA = int.Parse(Console.ReadLine()!);
Write("введите число B в степень которого вы хотите возвести число А: ");
int numB = int.Parse(Console.ReadLine()!);
// degree(numA, numB);
Write($"Число {numA} в натуральной степени {numB} = {degree1(numA, numB)}");



//Метод возведения в степень без цикла
// void degree(int a, int b)
// {
//     int sqr = Convert.ToInt32(Math.Pow(a, b));
//     Write(sqr);
// }


//Метод возведения в степень с циклом
int degree1(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    return result;
}


