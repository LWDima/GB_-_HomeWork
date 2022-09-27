// Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

using static System.Console;

Clear();
Write("Введите координат X первой точки ");
int x1 = Convert.ToInt32(ReadLine());
Write("Введите координат Y первой точки ");
int y1 = Convert.ToInt32(ReadLine());
Write("Введите координат Z первой точки ");
int z1 = Convert.ToInt32(ReadLine());
Write("Введите координат X второй точки ");
int x2 = Convert.ToInt32(ReadLine());
Write("Введите координат Y второй точки ");
int y2 = Convert.ToInt32(ReadLine());
Write("Введите координат Z второй точки ");
int z2 = Convert.ToInt32(ReadLine());

int A = x2 - x1;
int B = y2 - y1;
int C = z1 - z2;

double len = Math.Sqrt(A * A + B * B + C * C);
WriteLine($"Расстояние между точками А({x1},{y1},{z1}) и B({x2},{y2},{z2}) состовляет {len:f2}");

