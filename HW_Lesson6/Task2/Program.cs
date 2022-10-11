// Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

using static System.Console;
Clear();
WriteLine("Введите значения b1, k1, b2 и k2, через пробел: ");
string[] array = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
double[] num = ConvertString(array);
double x = (num[0] + num[2]) / (num[1] + num[3]);
double y = num[1] * x + num[0];
WriteLine($"Точка пересечения 2х прямых({x:f2}; {y:f2})");


double[] ConvertString(string[] input)
{
    double[] result = new double[input.Length];
    for (int i = 0; i < input.Length; i++)
    {
        result[i] = Convert.ToInt32(input[i]);
    }
    return result;
}



