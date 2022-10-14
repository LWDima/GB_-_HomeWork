// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

using static System.Console;
Clear();
Write("Введите положительное число M: ");
int m = int.Parse(ReadLine()!);

Write("Введите положительное число N: ");
int n = int.Parse(ReadLine()!);

FunAkker(m, n);


// вызов функции Аккермана
void FunAkker(int m, int n)
{
    Write(Akker(m, n));
}

// функция Аккермана
int Akker(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akker(m - 1, 1);
    }
    else
    {
        return (Akker(m - 1, Akker(m, n - 1)));
    }
}